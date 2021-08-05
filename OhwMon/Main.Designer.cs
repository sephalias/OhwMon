
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPortStatus = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.buttonSet = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.tabLogs = new System.Windows.Forms.TabPage();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.notifyIconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabData = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Controls.Add(this.tabData);
            this.tabControl1.Controls.Add(this.tabLogs);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(335, 201);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.panel1);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(327, 175);
            this.tabSettings.TabIndex = 0;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelPortStatus);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(8, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 146);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Interval";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPortStatus
            // 
            this.labelPortStatus.AutoSize = true;
            this.labelPortStatus.Location = new System.Drawing.Point(35, 60);
            this.labelPortStatus.Name = "labelPortStatus";
            this.labelPortStatus.Size = new System.Drawing.Size(52, 13);
            this.labelPortStatus.TabIndex = 1;
            this.labelPortStatus.Text = "Waiting...";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(10, 104);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.flowLayoutPanel1.Controls.Add(this.comboBoxPorts);
            this.flowLayoutPanel1.Controls.Add(this.buttonSet);
            this.flowLayoutPanel1.Controls.Add(this.buttonClear);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 28);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(297, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(3, 3);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(118, 21);
            this.comboBoxPorts.TabIndex = 1;
            // 
            // buttonSet
            // 
            this.buttonSet.Location = new System.Drawing.Point(127, 3);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(75, 23);
            this.buttonSet.TabIndex = 2;
            this.buttonSet.Text = "Set";
            this.buttonSet.UseVisualStyleBackColor = true;
            this.buttonSet.Click += new System.EventHandler(this.Button_Set);
            // 
            // buttonClear
            // 
            this.buttonClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClear.Location = new System.Drawing.Point(208, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.Button_Clear);
            // 
            // tabLogs
            // 
            this.tabLogs.Location = new System.Drawing.Point(4, 22);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogs.Size = new System.Drawing.Size(316, 175);
            this.tabLogs.TabIndex = 1;
            this.tabLogs.Text = "Logs";
            this.tabLogs.UseVisualStyleBackColor = true;
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
            this.statusStrip.Location = new System.Drawing.Point(0, 179);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(335, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(57, 17);
            this.toolStripStatusLabel.Text = "Waiting...";
            // 
            // tabData
            // 
            this.tabData.Location = new System.Drawing.Point(4, 22);
            this.tabData.Name = "tabData";
            this.tabData.Size = new System.Drawing.Size(316, 175);
            this.tabData.TabIndex = 2;
            this.tabData.Text = "Data";
            this.tabData.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 201);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "OhwMon";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPortStatus;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TabPage tabLogs;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.NotifyIcon notifyIconMain;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.TabPage tabData;
    }
}

