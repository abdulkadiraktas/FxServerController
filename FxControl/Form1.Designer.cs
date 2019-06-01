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
            this.btnChangeConfigLocation = new System.Windows.Forms.Button();
            this.txtconfig = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnChangeServerLocation = new System.Windows.Forms.Button();
            this.txtfx = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTxtLogScreen = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.MinimumSize = new System.Drawing.Size(446, 348);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(446, 348);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(438, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Control";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClearTimerList);
            this.groupBox2.Controls.Add(this.btnDeleteSelectedTime);
            this.groupBox2.Controls.Add(this.lstBoxTiming);
            this.groupBox2.Controls.Add(this.btnAddTimeToList);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 216);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Otomation";
            // 
            // btnClearTimerList
            // 
            this.btnClearTimerList.Location = new System.Drawing.Point(6, 167);
            this.btnClearTimerList.Name = "btnClearTimerList";
            this.btnClearTimerList.Size = new System.Drawing.Size(88, 38);
            this.btnClearTimerList.TabIndex = 4;
            this.btnClearTimerList.Text = "Clear List";
            this.btnClearTimerList.UseVisualStyleBackColor = true;
            this.btnClearTimerList.Click += new System.EventHandler(this.BtnClearTimerList_Click);
            // 
            // btnDeleteSelectedTime
            // 
            this.btnDeleteSelectedTime.Location = new System.Drawing.Point(6, 105);
            this.btnDeleteSelectedTime.Name = "btnDeleteSelectedTime";
            this.btnDeleteSelectedTime.Size = new System.Drawing.Size(88, 38);
            this.btnDeleteSelectedTime.TabIndex = 3;
            this.btnDeleteSelectedTime.Text = "Delete Selected";
            this.btnDeleteSelectedTime.UseVisualStyleBackColor = true;
            this.btnDeleteSelectedTime.Click += new System.EventHandler(this.BtnDeleteSelectedTime_Click);
            // 
            // lstBoxTiming
            // 
            this.lstBoxTiming.FormattingEnabled = true;
            this.lstBoxTiming.Location = new System.Drawing.Point(100, 19);
            this.lstBoxTiming.Name = "lstBoxTiming";
            this.lstBoxTiming.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstBoxTiming.Size = new System.Drawing.Size(145, 186);
            this.lstBoxTiming.TabIndex = 2;
            // 
            // btnAddTimeToList
            // 
            this.btnAddTimeToList.Location = new System.Drawing.Point(6, 45);
            this.btnAddTimeToList.Name = "btnAddTimeToList";
            this.btnAddTimeToList.Size = new System.Drawing.Size(88, 38);
            this.btnAddTimeToList.TabIndex = 1;
            this.btnAddTimeToList.Text = "Add List";
            this.btnAddTimeToList.UseVisualStyleBackColor = true;
            this.btnAddTimeToList.Click += new System.EventHandler(this.BtnAddTimeToList_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(88, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRestartServer);
            this.groupBox1.Controls.Add(this.btnStopServer);
            this.groupBox1.Controls.Add(this.btnStartServer);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Panel";
            // 
            // btnRestartServer
            // 
            this.btnRestartServer.FlatAppearance.BorderSize = 0;
            this.btnRestartServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.btnRestartServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnRestartServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestartServer.Location = new System.Drawing.Point(344, 19);
            this.btnRestartServer.Name = "btnRestartServer";
            this.btnRestartServer.Size = new System.Drawing.Size(82, 62);
            this.btnRestartServer.TabIndex = 2;
            this.btnRestartServer.Text = "Restart";
            this.btnRestartServer.UseVisualStyleBackColor = true;
            this.btnRestartServer.Click += new System.EventHandler(this.BtnRestartServer_Click);
            // 
            // btnStopServer
            // 
            this.btnStopServer.FlatAppearance.BorderSize = 0;
            this.btnStopServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.btnStopServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnStopServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopServer.Location = new System.Drawing.Point(177, 19);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(82, 62);
            this.btnStopServer.TabIndex = 1;
            this.btnStopServer.Text = "Stop";
            this.btnStopServer.UseVisualStyleBackColor = true;
            this.btnStopServer.Click += new System.EventHandler(this.BtnStopServer_Click);
            // 
            // btnStartServer
            // 
            this.btnStartServer.FlatAppearance.BorderSize = 0;
            this.btnStartServer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.btnStartServer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.btnStartServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartServer.Location = new System.Drawing.Point(6, 19);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(88, 62);
            this.btnStartServer.TabIndex = 0;
            this.btnStartServer.Text = "Start";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.BtnStartServer_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(438, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Setting";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnChangeConfigLocation);
            this.groupBox4.Controls.Add(this.txtconfig);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 103);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(432, 100);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Config file location";
            // 
            // btnChangeConfigLocation
            // 
            this.btnChangeConfigLocation.Location = new System.Drawing.Point(6, 45);
            this.btnChangeConfigLocation.Name = "btnChangeConfigLocation";
            this.btnChangeConfigLocation.Size = new System.Drawing.Size(416, 36);
            this.btnChangeConfigLocation.TabIndex = 1;
            this.btnChangeConfigLocation.Text = "Change config location";
            this.btnChangeConfigLocation.UseVisualStyleBackColor = true;
            this.btnChangeConfigLocation.Click += new System.EventHandler(this.BtnChangeConfigLocation_Click);
            // 
            // txtconfig
            // 
            this.txtconfig.Enabled = false;
            this.txtconfig.Location = new System.Drawing.Point(6, 19);
            this.txtconfig.Name = "txtconfig";
            this.txtconfig.Size = new System.Drawing.Size(416, 20);
            this.txtconfig.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnChangeServerLocation);
            this.groupBox3.Controls.Add(this.txtfx);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(432, 100);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Server file location";
            // 
            // btnChangeServerLocation
            // 
            this.btnChangeServerLocation.Location = new System.Drawing.Point(6, 45);
            this.btnChangeServerLocation.Name = "btnChangeServerLocation";
            this.btnChangeServerLocation.Size = new System.Drawing.Size(416, 36);
            this.btnChangeServerLocation.TabIndex = 1;
            this.btnChangeServerLocation.Text = "Change server location";
            this.btnChangeServerLocation.UseVisualStyleBackColor = true;
            this.btnChangeServerLocation.Click += new System.EventHandler(this.BtnChangeServerLocation_Click);
            // 
            // txtfx
            // 
            this.txtfx.Enabled = false;
            this.txtfx.Location = new System.Drawing.Point(6, 19);
            this.txtfx.Name = "txtfx";
            this.txtfx.Size = new System.Drawing.Size(416, 20);
            this.txtfx.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.richTxtLogScreen);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(438, 322);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Logs";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTxtLogScreen
            // 
            this.richTxtLogScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTxtLogScreen.Location = new System.Drawing.Point(3, 3);
            this.richTxtLogScreen.Name = "richTxtLogScreen";
            this.richTxtLogScreen.ReadOnly = true;
            this.richTxtLogScreen.Size = new System.Drawing.Size(432, 316);
            this.richTxtLogScreen.TabIndex = 0;
            this.richTxtLogScreen.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(438, 322);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Resource Panel";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridView1);
            this.groupBox6.Controls.Add(this.groupBox7);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox6.Location = new System.Drawing.Point(3, 114);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(422, 205);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Resource List";
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 65);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(416, 137);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopToolStripMenuItem,
            this.restartToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 48);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.StopToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.RestartToolStripMenuItem_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox2);
            this.groupBox7.Controls.Add(this.label1);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox7.Location = new System.Drawing.Point(3, 16);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(416, 49);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox2.Location = new System.Drawing.Point(3, 26);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(410, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button9);
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Controls.Add(this.textBox1);
            this.groupBox5.Controls.Add(this.button10);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(432, 111);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Command";
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(216, 19);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(200, 76);
            this.button9.TabIndex = 4;
            this.button9.Text = "Refresh";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "start",
            "stop",
            "restart"});
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(6, 72);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(195, 23);
            this.button10.TabIndex = 1;
            this.button10.Text = "Send Command";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 345);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(446, 36);
            this.progressBar1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 381);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.progressBar1);
            this.MaximumSize = new System.Drawing.Size(462, 870);
            this.MinimumSize = new System.Drawing.Size(462, 420);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FX Controller";
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
            this.tabPage3.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnChangeServerLocation;
        private System.Windows.Forms.TextBox txtfx;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnChangeConfigLocation;
        private System.Windows.Forms.TextBox txtconfig;
        private System.Windows.Forms.Button btnClearTimerList;
        private System.Windows.Forms.Button btnDeleteSelectedTime;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox richTxtLogScreen;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
    }
}

