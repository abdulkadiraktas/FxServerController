using FxControl.Properties;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FxControl
{
    public partial class Form1 : Form
    {
        private Process _process;

        DataTable dt;

        private Boolean _isFivemServerRunning, ServerStarted;

        string date;

        public Form1()
        {
            InitializeComponent();
        }

        private void Fxselectlocation()
        {
            if (string.IsNullOrWhiteSpace(Settings.Default.fxlocation))
            {
                OpenFileDialog fx = new OpenFileDialog
                {
                    Title = Resources.SelectServerExe,
                    Filter = "FXServer|FXServer.exe"
                };
                if (fx.ShowDialog() == DialogResult.OK)
                {
                    Settings.Default.fxlocation = fx.FileName;
                    Settings.Default.Save();
                    txtfx.Text = Settings.Default.fxlocation;
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                txtfx.Text = Settings.Default.fxlocation;
            }
        }

        private void Configselectlocation()
        {
            if (string.IsNullOrWhiteSpace(Settings.Default.config))
            {
                OpenFileDialog conf = new OpenFileDialog
                {
                    Title = Resources.SelectServerCfg,
                    Filter = "Config|server.cfg"
                };
                if (conf.ShowDialog() == DialogResult.OK)
                {
                    Settings.Default.config = conf.FileName;
                    Settings.Default.Save();
                    txtconfig.Text = Settings.Default.config;
                }
                else
                {
                    Close();
                }
            }
            else
            {
                txtconfig.Text = Settings.Default.config;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Settings.Default.config = "";
            //Settings.Default.fxlocation = "";
            //Settings.Default.Save();
            dt = new DataTable();
            dt.Columns.Add("resource");


            CheckForIllegalCrossThreadCalls = false;
            Fxselectlocation();
            Configselectlocation();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < lstBoxTiming.Items.Count; i++)
            {
                if (DateTime.Now.ToString("HH:mm:ss") == lstBoxTiming.Items[i].ToString())
                {
                    lstBoxTiming.Items.Remove(lstBoxTiming.Items[i]);
                    timer1.Stop();
                    OnRestart();
                }
            }

            if (_isFivemServerRunning)
            {
                btnStartServer.Enabled = false;
                btnStopServer.Enabled = true;
                btnRestartServer.Enabled = true;
                btnChangeServerLocation.Enabled = false;
                btnChangeConfigLocation.Enabled = false;
                CheckIfCrashed();
            }
            else
            {
                btnStartServer.Enabled = true;
                btnStopServer.Enabled = false;
                btnRestartServer.Enabled = false;
                btnChangeServerLocation.Enabled = true;
                btnChangeConfigLocation.Enabled = true;
                progressBar1.Value = 0;
                btnStartServer.BackColor = Color.Transparent;
            }

        }

        private void StopServer()
        {
            dt.Clear();
            _process.Kill();
            _isFivemServerRunning = false;
        }

        private void OnRestart()
        {
            StopServer();
            Thread.Sleep(5000);
            StartServer();
        }

        public void CheckIfCrashed()
        {
            if (!_isFivemServerRunning) return;

            if (!IsProcessRunning())
            {
                StartServer();
                return;
            }
        }

        private bool IsProcessRunning()
        {
            if (_process == null)
            {
                return false;
            }

            try
            {
                Process.GetProcessById(_process.Id);
            }
            catch (ArgumentException)
            {
                return false;
            }

            return true;
        }

        public void StartServer()
        {
            string path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "/Logs/";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            ServerStarted = false;
            string serverPath = Settings.Default.config.Replace("server.cfg", "");
            DirectoryInfo dir = new DirectoryInfo(@serverPath + "cache");
            if (dir.Exists)
            {
                try
                {
                    dir.Delete(true);
                }
                catch (Exception)
                {

                }
                Thread.Sleep(3000);
            }
            _process = new Process();

            var startInfo = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = Settings.Default.fxlocation,       // +set citizen_dir C:/FiveM/FXServer.exe
                Arguments = "+set citizen_dir " + Settings.Default.fxlocation.Replace("FXServer.exe", "") + // C:/FiveM
                         "/citizen/ +exec server.cfg",         // /citizen/ +exec server.cfg
                WorkingDirectory = Settings.Default.config.Replace("\\server.cfg", "")                    // C:/FiveM/cfx-server-data-master
            };
            startInfo.CreateNoWindow = true;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            _process.StartInfo = startInfo;
            _process.StartInfo.RedirectStandardInput = true;
            date = DateTime.Now.ToString("yyyy_MM_dd_HH_mm");
            _process.OutputDataReceived += CaptureOutput;
            _process.Start();
            _process.BeginOutputReadLine();
            _isFivemServerRunning = true;
        }

        //started resource
        private void CaptureOutput(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                Invoke(new Action(() => richTxtLogScreen.AppendText(Environment.NewLine + e.Data)));
                Invoke(new Action(() => richTxtLogScreen.ScrollToCaret()));
                if (e.Data == "Server license key authentication succeeded. Welcome!")
                {
                    ServerStarted = true;
                    progressBar1.Value = progressBar1.Maximum;
                    btnStartServer.BackColor = Color.Green;

                }
                else if (e.Data.Contains("Started resource"))
                {
                    //e.Data.Replace("started resource").Trim()
                    //  dataGridView1.Rows.Add(e.Data.Replace("Started resource", "").Trim());
                    //AddData(e.Data.Replace("Started resource", "").Trim());
                    Thread addDatathread = new Thread(() =>
                    AddData(e.Data.Replace("Started resource", "").Trim()));
                    addDatathread.Start();


                }
                if (!ServerStarted)
                {
                    if (progressBar1.Value < progressBar1.Maximum)
                    {
                        progressBar1.Value += 1;
                    }
                    else
                    {
                        progressBar1.Maximum += 100;
                    }
                }
                File.AppendAllText(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + "/Logs/" + date + ".txt", e.Data.ToString() + "\n");
            }
        }

        private void Ress(string status, string resourcename)
        {
            StreamWriter myStreamWriter = _process.StandardInput;
            myStreamWriter.WriteLine(status + " " + resourcename);
            myStreamWriter.Flush();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                Ress(comboBox1.Text, textBox1.Text);
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            StreamWriter myStreamWriter = _process.StandardInput;
            myStreamWriter.WriteLine("refresh");
            myStreamWriter.Flush();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                _process.Kill();
            }
            catch (Exception)
            {

            }
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Format("resource like '%{0}%'", textBox2.Text.Trim().Replace("'", "''"));
            }
            catch (Exception)
            {
            }
        }

        private void TextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void StopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Ress("stop", dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            }
        }

        private void RestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ress("restart", dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
        }

        private void BtnChangeServerLocation_Click(object sender, EventArgs e)
        {
            Settings.Default.fxlocation = null;
            Settings.Default.Save();
            Fxselectlocation();
        }

        private void BtnChangeConfigLocation_Click(object sender, EventArgs e)
        {
            Settings.Default.config = null;
            Settings.Default.Save();
            Configselectlocation();
        }

        private void BtnAddTimeToList_Click(object sender, EventArgs e)
        {
            lstBoxTiming.Items.Add(dateTimePicker1.Value.ToString("HH:mm:ss"));
        }

        private void BtnDeleteSelectedTime_Click(object sender, EventArgs e)
        {
            if (lstBoxTiming.SelectedItems.Count > 0)
            {
                for (int i = 0; i < lstBoxTiming.SelectedItems.Count; i++)
                {
                    lstBoxTiming.Items.Remove(lstBoxTiming.SelectedItems[i]);
                }
            }
        }

        private void BtnClearTimerList_Click(object sender, EventArgs e)
        {
            lstBoxTiming.Items.Clear();
        }

        private void Button8_Click(object sender, EventArgs e)
        {

        }

        private void BtnStartServer_Click(object sender, EventArgs e)
        {
            StartServer();
            progressBar1.Maximum = 100;
        }

        private void BtnStopServer_Click(object sender, EventArgs e)
        {
            richTxtLogScreen.Text = string.Empty;
            StopServer();
        }

        private void BtnRestartServer_Click(object sender, EventArgs e)
        {
            richTxtLogScreen.Text = string.Empty;
            OnRestart();
        }

        private Task AddData(string data)
        {
            DataRow row = dt.NewRow();
            row["resource"] = data;
            dt.Rows.Add(row);
            dataGridView1.DataSource = dt;
            return Task.CompletedTask;
        }
    }
}
