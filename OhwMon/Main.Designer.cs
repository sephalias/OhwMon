
namespace OhwMon
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.notifyIconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.tabWireless = new System.Windows.Forms.TabPage();
            this.listBoxRemoteLogs = new System.Windows.Forms.ListBox();
            this.lblServerStatus = new System.Windows.Forms.Label();
            this.btnServerStop = new System.Windows.Forms.Button();
            this.btnServerStart = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelIPAddress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabData = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCPUFanSpeed = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelCPULoad = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelCPUTemp = new System.Windows.Forms.Label();
            this.labelCPUName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelRAMUsage = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.labelGPUMemory = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelGPULoad = new System.Windows.Forms.Label();
            this.labelGPUName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelGPUTemp = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabSocketClient = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBoxClientLog = new System.Windows.Forms.ListBox();
            this.btnClientConnenct = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCPUClock = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.tabWireless.SuspendLayout();
            this.tabData.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabSocketClient.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerMain
            // 
            this.timerMain.Tick += new System.EventHandler(this.TimerMain_Tick);
            // 
            // notifyIconMain
            // 
            this.notifyIconMain.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMain.Icon")));
            this.notifyIconMain.Text = "notifyIcon";
            this.notifyIconMain.Visible = true;
            this.notifyIconMain.BalloonTipClicked += new System.EventHandler(this.NotificationIcon_DoubleClick);
            this.notifyIconMain.DoubleClick += new System.EventHandler(this.NotificationIcon_DoubleClick);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 283);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(335, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(57, 17);
            this.toolStripStatusLabel.Text = "Waiting...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Set";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabWireless
            // 
            this.tabWireless.Controls.Add(this.listBoxRemoteLogs);
            this.tabWireless.Controls.Add(this.lblServerStatus);
            this.tabWireless.Controls.Add(this.btnServerStop);
            this.tabWireless.Controls.Add(this.btnServerStart);
            this.tabWireless.Controls.Add(this.label11);
            this.tabWireless.Controls.Add(this.button3);
            this.tabWireless.Controls.Add(this.button2);
            this.tabWireless.Controls.Add(this.label9);
            this.tabWireless.Controls.Add(this.textBox1);
            this.tabWireless.Controls.Add(this.labelIPAddress);
            this.tabWireless.Controls.Add(this.label5);
            this.tabWireless.Location = new System.Drawing.Point(4, 22);
            this.tabWireless.Name = "tabWireless";
            this.tabWireless.Size = new System.Drawing.Size(327, 279);
            this.tabWireless.TabIndex = 3;
            this.tabWireless.Text = "Wireless";
            this.tabWireless.UseVisualStyleBackColor = true;
            // 
            // listBoxRemoteLogs
            // 
            this.listBoxRemoteLogs.FormattingEnabled = true;
            this.listBoxRemoteLogs.Location = new System.Drawing.Point(3, 135);
            this.listBoxRemoteLogs.Name = "listBoxRemoteLogs";
            this.listBoxRemoteLogs.Size = new System.Drawing.Size(321, 121);
            this.listBoxRemoteLogs.TabIndex = 10;
            // 
            // lblServerStatus
            // 
            this.lblServerStatus.AutoSize = true;
            this.lblServerStatus.Location = new System.Drawing.Point(12, 112);
            this.lblServerStatus.Name = "lblServerStatus";
            this.lblServerStatus.Size = new System.Drawing.Size(50, 13);
            this.lblServerStatus.TabIndex = 9;
            this.lblServerStatus.Text = "Running.";
            // 
            // btnServerStop
            // 
            this.btnServerStop.Location = new System.Drawing.Point(201, 102);
            this.btnServerStop.Name = "btnServerStop";
            this.btnServerStop.Size = new System.Drawing.Size(75, 23);
            this.btnServerStop.TabIndex = 8;
            this.btnServerStop.Text = "Stop";
            this.btnServerStop.UseVisualStyleBackColor = true;
            this.btnServerStop.Click += new System.EventHandler(this.btnStopServer_Click);
            // 
            // btnServerStart
            // 
            this.btnServerStart.Location = new System.Drawing.Point(119, 102);
            this.btnServerStart.Name = "btnServerStart";
            this.btnServerStart.Size = new System.Drawing.Size(75, 23);
            this.btnServerStart.TabIndex = 7;
            this.btnServerStart.Text = "Start";
            this.btnServerStart.UseVisualStyleBackColor = true;
            this.btnServerStart.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Status";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(200, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(119, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Port";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "2418";
            // 
            // labelIPAddress
            // 
            this.labelIPAddress.AutoSize = true;
            this.labelIPAddress.Location = new System.Drawing.Point(79, 14);
            this.labelIPAddress.Name = "labelIPAddress";
            this.labelIPAddress.Size = new System.Drawing.Size(77, 13);
            this.labelIPAddress.TabIndex = 1;
            this.labelIPAddress.Text = "labelIPAddress";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "IP Address:";
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.flowLayoutPanel2);
            this.tabData.Location = new System.Drawing.Point(4, 22);
            this.tabData.Name = "tabData";
            this.tabData.Size = new System.Drawing.Size(327, 279);
            this.tabData.TabIndex = 2;
            this.tabData.Text = "Data";
            this.tabData.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.groupBox1);
            this.flowLayoutPanel2.Controls.Add(this.groupBox2);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(8, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(311, 151);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCPUClock);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelCPUFanSpeed);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.labelCPULoad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.labelCPUTemp);
            this.groupBox1.Controls.Add(this.labelCPUName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CPU";
            // 
            // labelCPUFanSpeed
            // 
            this.labelCPUFanSpeed.AutoSize = true;
            this.labelCPUFanSpeed.Location = new System.Drawing.Point(235, 46);
            this.labelCPUFanSpeed.Name = "labelCPUFanSpeed";
            this.labelCPUFanSpeed.Size = new System.Drawing.Size(100, 13);
            this.labelCPUFanSpeed.TabIndex = 7;
            this.labelCPUFanSpeed.Text = "labelCPUFanSpeed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(192, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fan:";
            // 
            // labelCPULoad
            // 
            this.labelCPULoad.AutoSize = true;
            this.labelCPULoad.Location = new System.Drawing.Point(75, 46);
            this.labelCPULoad.Name = "labelCPULoad";
            this.labelCPULoad.Size = new System.Drawing.Size(75, 13);
            this.labelCPULoad.TabIndex = 5;
            this.labelCPULoad.Text = "labelCPULoad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Load:";
            // 
            // labelCPUTemp
            // 
            this.labelCPUTemp.AutoSize = true;
            this.labelCPUTemp.Location = new System.Drawing.Point(75, 33);
            this.labelCPUTemp.Name = "labelCPUTemp";
            this.labelCPUTemp.Size = new System.Drawing.Size(78, 13);
            this.labelCPUTemp.TabIndex = 3;
            this.labelCPUTemp.Text = "labelCPUTemp";
            // 
            // labelCPUName
            // 
            this.labelCPUName.AutoSize = true;
            this.labelCPUName.Location = new System.Drawing.Point(75, 20);
            this.labelCPUName.Name = "labelCPUName";
            this.labelCPUName.Size = new System.Drawing.Size(79, 13);
            this.labelCPUName.TabIndex = 2;
            this.labelCPUName.Text = "labelCPUName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Temperature:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "CPU Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelRAMUsage);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.labelGPUMemory);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.labelGPULoad);
            this.groupBox2.Controls.Add(this.labelGPUName);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.labelGPUTemp);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(3, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 77);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GPU & RAM";
            // 
            // labelRAMUsage
            // 
            this.labelRAMUsage.AutoSize = true;
            this.labelRAMUsage.Location = new System.Drawing.Point(214, 42);
            this.labelRAMUsage.Name = "labelRAMUsage";
            this.labelRAMUsage.Size = new System.Drawing.Size(67, 13);
            this.labelRAMUsage.TabIndex = 15;
            this.labelRAMUsage.Text = "Usage/Total";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(214, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "RAM";
            // 
            // labelGPUMemory
            // 
            this.labelGPUMemory.AutoSize = true;
            this.labelGPUMemory.Location = new System.Drawing.Point(75, 55);
            this.labelGPUMemory.Name = "labelGPUMemory";
            this.labelGPUMemory.Size = new System.Drawing.Size(89, 13);
            this.labelGPUMemory.TabIndex = 13;
            this.labelGPUMemory.Text = "labelGPUMemory";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Memory:";
            // 
            // labelGPULoad
            // 
            this.labelGPULoad.AutoSize = true;
            this.labelGPULoad.Location = new System.Drawing.Point(75, 42);
            this.labelGPULoad.Name = "labelGPULoad";
            this.labelGPULoad.Size = new System.Drawing.Size(76, 13);
            this.labelGPULoad.TabIndex = 11;
            this.labelGPULoad.Text = "labelGPULoad";
            // 
            // labelGPUName
            // 
            this.labelGPUName.AutoSize = true;
            this.labelGPUName.Location = new System.Drawing.Point(75, 16);
            this.labelGPUName.Name = "labelGPUName";
            this.labelGPUName.Size = new System.Drawing.Size(80, 13);
            this.labelGPUName.TabIndex = 8;
            this.labelGPUName.Text = "labelGPUName";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Load:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "GPU Name:";
            // 
            // labelGPUTemp
            // 
            this.labelGPUTemp.AutoSize = true;
            this.labelGPUTemp.Location = new System.Drawing.Point(75, 29);
            this.labelGPUTemp.Name = "labelGPUTemp";
            this.labelGPUTemp.Size = new System.Drawing.Size(79, 13);
            this.labelGPUTemp.TabIndex = 9;
            this.labelGPUTemp.Text = "labelGPUTemp";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Temperature:";
            // 
            // tabSocketClient
            // 
            this.tabSocketClient.Controls.Add(this.tabData);
            this.tabSocketClient.Controls.Add(this.tabWireless);
            this.tabSocketClient.Controls.Add(this.tabPage1);
            this.tabSocketClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSocketClient.Location = new System.Drawing.Point(0, 0);
            this.tabSocketClient.Name = "tabSocketClient";
            this.tabSocketClient.SelectedIndex = 0;
            this.tabSocketClient.Size = new System.Drawing.Size(335, 305);
            this.tabSocketClient.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxClientLog);
            this.tabPage1.Controls.Add(this.btnClientConnenct);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(327, 279);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBoxClientLog
            // 
            this.listBoxClientLog.FormattingEnabled = true;
            this.listBoxClientLog.Location = new System.Drawing.Point(7, 50);
            this.listBoxClientLog.Name = "listBoxClientLog";
            this.listBoxClientLog.Size = new System.Drawing.Size(312, 199);
            this.listBoxClientLog.TabIndex = 1;
            // 
            // btnClientConnenct
            // 
            this.btnClientConnenct.Location = new System.Drawing.Point(246, 21);
            this.btnClientConnenct.Name = "btnClientConnenct";
            this.btnClientConnenct.Size = new System.Drawing.Size(75, 23);
            this.btnClientConnenct.TabIndex = 0;
            this.btnClientConnenct.Text = "Connect";
            this.btnClientConnenct.UseVisualStyleBackColor = true;
            this.btnClientConnenct.Click += new System.EventHandler(this.btnClientConnenct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Clock:";
            // 
            // labelCPUClock
            // 
            this.labelCPUClock.AutoSize = true;
            this.labelCPUClock.Location = new System.Drawing.Point(235, 33);
            this.labelCPUClock.Name = "labelCPUClock";
            this.labelCPUClock.Size = new System.Drawing.Size(78, 13);
            this.labelCPUClock.TabIndex = 9;
            this.labelCPUClock.Text = "labelCPUClock";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 305);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabSocketClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "OhwMon";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabWireless.ResumeLayout(false);
            this.tabWireless.PerformLayout();
            this.tabData.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabSocketClient.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.NotifyIcon notifyIconMain;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabWireless;
        private System.Windows.Forms.ListBox listBoxRemoteLogs;
        private System.Windows.Forms.Label lblServerStatus;
        private System.Windows.Forms.Button btnServerStop;
        private System.Windows.Forms.Button btnServerStart;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelIPAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCPUFanSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCPULoad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelCPUTemp;
        private System.Windows.Forms.Label labelCPUName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelRAMUsage;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelGPUMemory;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelGPULoad;
        private System.Windows.Forms.Label labelGPUName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelGPUTemp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabControl tabSocketClient;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBoxClientLog;
        private System.Windows.Forms.Button btnClientConnenct;
        private System.Windows.Forms.Label labelCPUClock;
        private System.Windows.Forms.Label label1;
    }
}

