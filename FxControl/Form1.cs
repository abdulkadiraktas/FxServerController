using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FxControl
{
    public partial class Form1 : Form
    {
        private Process _process;
        private Boolean _isFivemServerRunning, oyunbasladı;
        public Form1()
        {
            InitializeComponent();
        }

        private void fxselectlocation()
        {
            if (FxControl.Properties.Settings.Default.fxlocation == ""|| FxControl.Properties.Settings.Default.fxlocation == null)
            {
                OpenFileDialog fx = new OpenFileDialog();
                fx.Title = "Please select FXServer.exe"; 
                fx.Filter = "FXServer|FXServer.exe";
                if (fx.ShowDialog() == DialogResult.OK)
                {
                    FxControl.Properties.Settings.Default.fxlocation = fx.FileName;
                    FxControl.Properties.Settings.Default.Save();
                    txtfx.Text = FxControl.Properties.Settings.Default.fxlocation;
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                txtfx.Text = FxControl.Properties.Settings.Default.fxlocation;
            }
        }
        private void configselectlocation()
        {
            if (FxControl.Properties.Settings.Default.config == "" || FxControl.Properties.Settings.Default.config == null)
            {
                OpenFileDialog conf = new OpenFileDialog();
                conf.Title = "Please select server.cfg"; 
                conf.Filter = "Config|server.cfg";
                if (conf.ShowDialog() == DialogResult.OK)
                {
                    FxControl.Properties.Settings.Default.config = conf.FileName;
                    FxControl.Properties.Settings.Default.Save();
                    txtconfig.Text = FxControl.Properties.Settings.Default.config;
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                txtconfig.Text = FxControl.Properties.Settings.Default.config;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //FxControl.Properties.Settings.Default.config = "";
            //FxControl.Properties.Settings.Default.fxlocation = "";
            //FxControl.Properties.Settings.Default.Save();
            Control.CheckForIllegalCrossThreadCalls = false;
            fxselectlocation();
            configselectlocation();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(dateTimePicker1.Value.ToString("HH:mm:ss"));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {  
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (DateTime.Now.ToString("HH:mm:ss") == listBox1.Items[i].ToString())
                {
                    listBox1.Items.Remove(listBox1.Items[i]);
                    timer1.Stop();
                    OnRestart();
                }
            }

            if (_isFivemServerRunning)
            {
                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;
                button5.Enabled = false;
                button6.Enabled = false;
                CheckIfCrashed();
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = false;
                button3.Enabled = false;
                button5.Enabled = true;
                button6.Enabled = true;
                progressBar1.Value = 0;
                button1.BackColor = Color.Transparent;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FxControl.Properties.Settings.Default.fxlocation = null;
            FxControl.Properties.Settings.Default.Save();
            fxselectlocation();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FxControl.Properties.Settings.Default.config = null;
            FxControl.Properties.Settings.Default.Save();
            configselectlocation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartServer();
            progressBar1.Maximum = 100;


        }

        private void StopServer()
        {
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
            if (this._process == null)
            {
                return false;
            }

            try
            {
                Process.GetProcessById(this._process.Id);
            }
            catch (ArgumentException)
            {
                return false;
            }

            return true;
        }

        public void StartServer()
        {
            oyunbasladı = false;
            string serverPath = FxControl.Properties.Settings.Default.config.Replace("server.cfg", "");
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@serverPath + "cache");
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
                FileName = FxControl.Properties.Settings.Default.fxlocation,       // +set citizen_dir C:/FiveM/FXServer.exe
                Arguments = "+set citizen_dir " + FxControl.Properties.Settings.Default.fxlocation.Replace("FXServer.exe", "") + // C:/FiveM
                         "/citizen/ +exec server.cfg",         // /citizen/ +exec server.cfg
                WorkingDirectory = FxControl.Properties.Settings.Default.config.Replace("\\server.cfg", "")                    // C:/FiveM/cfx-server-data-master
            };
            startInfo.CreateNoWindow = true;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            _process.StartInfo = startInfo;
            // string date = DateTime.Now.ToString("yyyy_MM_dd_HH_mm"); 
            _process.OutputDataReceived += CaptureOutput;
            _process.Start();
            _process.BeginOutputReadLine();
            _isFivemServerRunning = true;
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            StopServer();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            OnRestart();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listBox1.SelectedItems.Count; i++)
                {
                    listBox1.Items.Remove(listBox1.SelectedItems[i]);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void CaptureOutput(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                richTextBox1.Text = e.Data + Environment.NewLine + richTextBox1.Text;
                if (e.Data== "Server license key authentication succeeded. Welcome!")
                {
                    oyunbasladı = true;
                    progressBar1.Value = progressBar1.Maximum;
                    
                    button1.BackColor = Color.Green;
                }
                if (!oyunbasladı)
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
            }
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
    }
}
