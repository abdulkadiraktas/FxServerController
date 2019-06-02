using FxControl.Properties;

namespace FxControl
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClearTimerList = new System.Windows.Forms.Button();
            this.btnDeleteSelectedTime = new System.Windows.Forms.Button();
            this.lstBoxTiming = new System.Windows.Forms.ListBox();
            this.btnAddTimeToList = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRestartServer = new System.Windows.Forms.Button();
            this.btnStopServer = new System.Windows.Forms.Button();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblSelectLanguage = new System.Windows.Forms.Label();
            this.cmbSelectLanguage = new System.Windows.Forms.ComboBox();
            this.chckBoxEnableServerLogs = new System.Windows.Forms.CheckBox();
            this.chckBoxClearCache = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtServerLogsLocation = new System.Windows.Forms.TextBox();
            this.btnChangeServerLogsLocation = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChangeConfigLocation = new System.Windows.Forms.Button();
            this.txtServerCfgLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChangeServerLocation = new System.Windows.Forms.Button();
            this.txtServerExeLocation = new System.Windows.Forms.TextBox();
            this.lblServerExe = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtSearchResource = new System.Windows.Forms.TextBox();
            this.lblSearchresource = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnRefreshServer = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtSendCommand = new System.Windows.Forms.TextBox();
            this.btnSendCommand = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnShowLogs = new System.Windows.Forms.Button();
            this.richTxtLogScreen = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClearTimerList);
            this.groupBox2.Controls.Add(this.btnDeleteSelectedTime);
            this.groupBox2.Controls.Add(this.lstBoxTiming);
            this.groupBox2.Controls.Add(this.btnAddTimeToList);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // btnClearTimerList
            // 
            resources.ApplyResources(this.btnClearTimerList, "btnClearTimerList");
            this.btnClearTimerList.Name = "btnClearTimerList";
            this.btnClearTimerList.UseVisualStyleBackColor = true;
            this.btnClearTimerList.Click += new System.EventHandler(this.BtnClearTimerList_Click);
            // 
            // btnDeleteSelectedTime
            // 
            resources.ApplyResources(this.btnDeleteSelectedTime, "btnDeleteSelectedTime");
            this.btnDeleteSelectedTime.Name = "btnDeleteSelectedTime";
            this.btnDeleteSelectedTime.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedTime.Click += new System.EventHandler(this.BtnDeleteSelectedTime_Click);
            // 
            // lstBoxTiming
            // 
            this.lstBoxTiming.FormattingEnabled = true;
            resources.ApplyResources(this.lstBoxTiming, "lstBoxTiming");
            this.lstBoxTiming.Name = "lstBoxTiming";
            this.lstBoxTiming.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            // 
            // btnAddTimeToList
            // 
            resources.ApplyResources(this.btnAddTimeToList, "btnAddTimeToList");
            this.btnAddTimeToList.Name = "btnAddTimeToList";
            this.btnAddTimeToList.UseVisualStyleBackColor = true;
            this.btnAddTimeToList.Click += new System.EventHandler(this.BtnAddTimeToList_Click);
            // 
            // dateTimePicker1
            // 
            resources.ApplyResources(this.dateTimePicker1, "dateTimePicker1");
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRestartServer);
            this.groupBox1.Controls.Add(this.btnStopServer);
            this.groupBox1.Controls.Add(this.btnStartServer);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnRestartServer
            // 
            this.btnRestartServer.FlatAppearance.BorderSize = 0;
            this.btnRestartServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.btnRestartServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            resources.ApplyResources(this.btnRestartServer, "btnRestartServer");
            this.btnRestartServer.Name = "btnRestartServer";
            this.btnRestartServer.UseVisualStyleBackColor = true;
            this.btnRestartServer.Click += new System.EventHandler(this.BtnRestartServer_Click);
            // 
            // btnStopServer
            // 
            this.btnStopServer.FlatAppearance.BorderSize = 0;
            this.btnStopServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.btnStopServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            resources.ApplyResources(this.btnStopServer, "btnStopServer");
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.UseVisualStyleBackColor = true;
            this.btnStopServer.Click += new System.EventHandler(this.BtnStopServer_Click);
            // 
            // btnStartServer
            // 
            this.btnStartServer.FlatAppearance.BorderSize = 0;
            this.btnStartServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.btnStartServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            resources.ApplyResources(this.btnStartServer, "btnStartServer");
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.BtnStartServer_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblSelectLanguage);
            this.groupBox4.Controls.Add(this.cmbSelectLanguage);
            this.groupBox4.Controls.Add(this.chckBoxEnableServerLogs);
            this.groupBox4.Controls.Add(this.chckBoxClearCache);
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // lblSelectLanguage
            // 
            resources.ApplyResources(this.lblSelectLanguage, "lblSelectLanguage");
            this.lblSelectLanguage.Name = "lblSelectLanguage";
            // 
            // cmbSelectLanguage
            // 
            this.cmbSelectLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectLanguage.FormattingEnabled = true;
            resources.ApplyResources(this.cmbSelectLanguage, "cmbSelectLanguage");
            this.cmbSelectLanguage.Name = "cmbSelectLanguage";
            this.cmbSelectLanguage.SelectedIndexChanged += new System.EventHandler(this.CmbSelectLanguage_SelectedIndexChanged);
            // 
            // chckBoxEnableServerLogs
            // 
            resources.ApplyResources(this.chckBoxEnableServerLogs, "chckBoxEnableServerLogs");
            this.chckBoxEnableServerLogs.Name = "chckBoxEnableServerLogs";
            this.chckBoxEnableServerLogs.UseVisualStyleBackColor = true;
            this.chckBoxEnableServerLogs.CheckedChanged += new System.EventHandler(this.ChckBoxEnableServerLogs_CheckedChanged);
            // 
            // chckBoxClearCache
            // 
            resources.ApplyResources(this.chckBoxClearCache, "chckBoxClearCache");
            this.chckBoxClearCache.Name = "chckBoxClearCache";
            this.chckBoxClearCache.UseVisualStyleBackColor = true;
            this.chckBoxClearCache.CheckedChanged += new System.EventHandler(this.ChckBoxClearCache_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtServerLogsLocation);
            this.groupBox3.Controls.Add(this.btnChangeServerLogsLocation);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnChangeConfigLocation);
            this.groupBox3.Controls.Add(this.txtServerCfgLocation);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnChangeServerLocation);
            this.groupBox3.Controls.Add(this.txtServerExeLocation);
            this.groupBox3.Controls.Add(this.lblServerExe);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // txtServerLogsLocation
            // 
            resources.ApplyResources(this.txtServerLogsLocation, "txtServerLogsLocation");
            this.txtServerLogsLocation.Name = "txtServerLogsLocation";
            this.txtServerLogsLocation.ReadOnly = true;
            // 
            // btnChangeServerLogsLocation
            // 
            resources.ApplyResources(this.btnChangeServerLogsLocation, "btnChangeServerLogsLocation");
            this.btnChangeServerLogsLocation.Name = "btnChangeServerLogsLocation";
            this.btnChangeServerLogsLocation.UseVisualStyleBackColor = true;
            this.btnChangeServerLogsLocation.Click += new System.EventHandler(this.BtnChangeServerLogsLocation_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btnChangeConfigLocation
            // 
            resources.ApplyResources(this.btnChangeConfigLocation, "btnChangeConfigLocation");
            this.btnChangeConfigLocation.Name = "btnChangeConfigLocation";
            this.btnChangeConfigLocation.UseVisualStyleBackColor = true;
            this.btnChangeConfigLocation.Click += new System.EventHandler(this.BtnChangeConfigLocation_Click);
            // 
            // txtServerCfgLocation
            // 
            resources.ApplyResources(this.txtServerCfgLocation, "txtServerCfgLocation");
            this.txtServerCfgLocation.Name = "txtServerCfgLocation";
            this.txtServerCfgLocation.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnChangeServerLocation
            // 
            resources.ApplyResources(this.btnChangeServerLocation, "btnChangeServerLocation");
            this.btnChangeServerLocation.Name = "btnChangeServerLocation";
            this.btnChangeServerLocation.UseVisualStyleBackColor = true;
            this.btnChangeServerLocation.Click += new System.EventHandler(this.BtnChangeServerLocation_Click);
            // 
            // txtServerExeLocation
            // 
            resources.ApplyResources(this.txtServerExeLocation, "txtServerExeLocation");
            this.txtServerExeLocation.Name = "txtServerExeLocation";
            this.txtServerExeLocation.ReadOnly = true;
            // 
            // lblServerExe
            // 
            resources.ApplyResources(this.lblServerExe, "lblServerExe");
            this.lblServerExe.Name = "lblServerExe";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Controls.Add(this.groupBox5);
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridView1);
            this.groupBox6.Controls.Add(this.groupBox7);
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopToolStripMenuItem,
            this.restartToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            resources.ApplyResources(this.stopToolStripMenuItem, "stopToolStripMenuItem");
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.StopToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            resources.ApplyResources(this.restartToolStripMenuItem, "restartToolStripMenuItem");
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.RestartToolStripMenuItem_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtSearchResource);
            this.groupBox7.Controls.Add(this.lblSearchresource);
            resources.ApplyResources(this.groupBox7, "groupBox7");
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.TabStop = false;
            // 
            // txtSearchResource
            // 
            resources.ApplyResources(this.txtSearchResource, "txtSearchResource");
            this.txtSearchResource.Name = "txtSearchResource";
            this.txtSearchResource.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // lblSearchresource
            // 
            resources.ApplyResources(this.lblSearchresource, "lblSearchresource");
            this.lblSearchresource.Name = "lblSearchresource";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnRefreshServer);
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Controls.Add(this.txtSendCommand);
            this.groupBox5.Controls.Add(this.btnSendCommand);
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // btnRefreshServer
            // 
            this.btnRefreshServer.FlatAppearance.BorderSize = 0;
            this.btnRefreshServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.btnRefreshServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            resources.ApplyResources(this.btnRefreshServer, "btnRefreshServer");
            this.btnRefreshServer.Name = "btnRefreshServer";
            this.btnRefreshServer.UseVisualStyleBackColor = true;
            this.btnRefreshServer.Click += new System.EventHandler(this.Button9_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2")});
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // txtSendCommand
            // 
            resources.ApplyResources(this.txtSendCommand, "txtSendCommand");
            this.txtSendCommand.Name = "txtSendCommand";
            // 
            // btnSendCommand
            // 
            resources.ApplyResources(this.btnSendCommand, "btnSendCommand");
            this.btnSendCommand.Name = "btnSendCommand";
            this.btnSendCommand.UseVisualStyleBackColor = true;
            this.btnSendCommand.Click += new System.EventHandler(this.Button10_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // btnShowLogs
            // 
            resources.ApplyResources(this.btnShowLogs, "btnShowLogs");
            this.btnShowLogs.Name = "btnShowLogs";
            this.btnShowLogs.UseVisualStyleBackColor = true;
            this.btnShowLogs.Click += new System.EventHandler(this.BtnShowLogs_Click);
            // 
            // richTxtLogScreen
            // 
            this.richTxtLogScreen.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.richTxtLogScreen, "richTxtLogScreen");
            this.richTxtLogScreen.ForeColor = System.Drawing.Color.White;
            this.richTxtLogScreen.Name = "richTxtLogScreen";
            this.richTxtLogScreen.ReadOnly = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAddTimeToList;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTxtLogScreen);
            this.Controls.Add(this.btnShowLogs);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRestartServer;
        private System.Windows.Forms.Button btnStopServer;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstBoxTiming;
        private System.Windows.Forms.Button btnAddTimeToList;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnClearTimerList;
        private System.Windows.Forms.Button btnDeleteSelectedTime;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnSendCommand;
        private System.Windows.Forms.TextBox txtSendCommand;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnRefreshServer;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtSearchResource;
        private System.Windows.Forms.Label lblSearchresource;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnChangeServerLocation;
        private System.Windows.Forms.TextBox txtServerExeLocation;
        private System.Windows.Forms.Label lblServerExe;
        private System.Windows.Forms.Button btnChangeServerLogsLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChangeConfigLocation;
        private System.Windows.Forms.TextBox txtServerCfgLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chckBoxClearCache;
        private System.Windows.Forms.CheckBox chckBoxEnableServerLogs;
        private System.Windows.Forms.TextBox txtServerLogsLocation;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnShowLogs;
        private System.Windows.Forms.RichTextBox richTxtLogScreen;
        private System.Windows.Forms.Label lblSelectLanguage;
        private System.Windows.Forms.ComboBox cmbSelectLanguage;
    }
}

