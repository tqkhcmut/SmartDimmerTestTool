namespace SmartDimmerTestTool
{
    partial class SmartDimmerTT
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.get_temp_bt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.message_rtext = new System.Windows.Forms.RichTextBox();
            this.COMSerialPort = new System.IO.Ports.SerialPort(this.components);
            this.SerialListener = new System.ComponentModel.BackgroundWorker();
            this.GetPCBTime_bt = new System.Windows.Forms.Button();
            this.GetPower_bt = new System.Windows.Forms.Button();
            this.GetID_bt = new System.Windows.Forms.Button();
            this.Temp_tb = new System.Windows.Forms.TextBox();
            this.PCBTime_tb = new System.Windows.Forms.TextBox();
            this.Power_tb = new System.Windows.Forms.TextBox();
            this.ID_tb = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ManualModeOff_bt = new System.Windows.Forms.Button();
            this.ManualModeOn_bt = new System.Windows.Forms.Button();
            this.GetScheduler_bt = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SearchL1_bt = new System.Windows.Forms.Button();
            this.SearchL2_bt = new System.Windows.Forms.Button();
            this.SearchL3_bt = new System.Windows.Forms.Button();
            this.DevUnpair_bt = new System.Windows.Forms.Button();
            this.DevPair_bt = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.GetIDFromTime_bt = new System.Windows.Forms.Button();
            this.IDFromTime_tb = new System.Windows.Forms.TextBox();
            this.SetIDToPCB_bt = new System.Windows.Forms.Button();
            this.FoundID_rtext = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TargetID_cb = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.serialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // serialToolStripMenuItem
            // 
            this.serialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem,
            this.connectToolStripMenuItem});
            this.serialToolStripMenuItem.Name = "serialToolStripMenuItem";
            this.serialToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.serialToolStripMenuItem.Text = "Serial";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.settingToolStripMenuItem.Text = "Setting...";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 332);
            this.panel1.TabIndex = 1;
            // 
            // get_temp_bt
            // 
            this.get_temp_bt.Location = new System.Drawing.Point(6, 19);
            this.get_temp_bt.Name = "get_temp_bt";
            this.get_temp_bt.Size = new System.Drawing.Size(104, 23);
            this.get_temp_bt.TabIndex = 0;
            this.get_temp_bt.Text = "Get Temperature";
            this.get_temp_bt.UseVisualStyleBackColor = true;
            this.get_temp_bt.Click += new System.EventHandler(this.get_temp_bt_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 356);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 206);
            this.panel2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.message_rtext);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Message";
            // 
            // message_rtext
            // 
            this.message_rtext.BackColor = System.Drawing.SystemColors.Window;
            this.message_rtext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.message_rtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.message_rtext.Location = new System.Drawing.Point(3, 16);
            this.message_rtext.Name = "message_rtext";
            this.message_rtext.ReadOnly = true;
            this.message_rtext.Size = new System.Drawing.Size(775, 187);
            this.message_rtext.TabIndex = 0;
            this.message_rtext.Text = "";
            // 
            // COMSerialPort
            // 
            this.COMSerialPort.BaudRate = 115200;
            this.COMSerialPort.PortName = "COM11";
            this.COMSerialPort.ReadTimeout = 1000;
            this.COMSerialPort.WriteTimeout = 1000;
            // 
            // SerialListener
            // 
            this.SerialListener.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SerialListener_DoWork);
            this.SerialListener.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SerialListener_finished);
            // 
            // GetPCBTime_bt
            // 
            this.GetPCBTime_bt.Location = new System.Drawing.Point(6, 48);
            this.GetPCBTime_bt.Name = "GetPCBTime_bt";
            this.GetPCBTime_bt.Size = new System.Drawing.Size(104, 23);
            this.GetPCBTime_bt.TabIndex = 1;
            this.GetPCBTime_bt.Text = "Get PCB Time";
            this.GetPCBTime_bt.UseVisualStyleBackColor = true;
            this.GetPCBTime_bt.Click += new System.EventHandler(this.GetPCBTime_bt_Click);
            // 
            // GetPower_bt
            // 
            this.GetPower_bt.Location = new System.Drawing.Point(6, 77);
            this.GetPower_bt.Name = "GetPower_bt";
            this.GetPower_bt.Size = new System.Drawing.Size(104, 23);
            this.GetPower_bt.TabIndex = 2;
            this.GetPower_bt.Text = "Get Power";
            this.GetPower_bt.UseVisualStyleBackColor = true;
            this.GetPower_bt.Click += new System.EventHandler(this.GetPower_bt_Click);
            // 
            // GetID_bt
            // 
            this.GetID_bt.Location = new System.Drawing.Point(6, 106);
            this.GetID_bt.Name = "GetID_bt";
            this.GetID_bt.Size = new System.Drawing.Size(104, 23);
            this.GetID_bt.TabIndex = 3;
            this.GetID_bt.Text = "Get ID";
            this.GetID_bt.UseVisualStyleBackColor = true;
            this.GetID_bt.Click += new System.EventHandler(this.GetID_bt_Click);
            // 
            // Temp_tb
            // 
            this.Temp_tb.Location = new System.Drawing.Point(116, 21);
            this.Temp_tb.Name = "Temp_tb";
            this.Temp_tb.Size = new System.Drawing.Size(100, 20);
            this.Temp_tb.TabIndex = 4;
            // 
            // PCBTime_tb
            // 
            this.PCBTime_tb.Location = new System.Drawing.Point(116, 50);
            this.PCBTime_tb.Name = "PCBTime_tb";
            this.PCBTime_tb.Size = new System.Drawing.Size(100, 20);
            this.PCBTime_tb.TabIndex = 5;
            // 
            // Power_tb
            // 
            this.Power_tb.Location = new System.Drawing.Point(116, 79);
            this.Power_tb.Name = "Power_tb";
            this.Power_tb.Size = new System.Drawing.Size(100, 20);
            this.Power_tb.TabIndex = 6;
            // 
            // ID_tb
            // 
            this.ID_tb.Location = new System.Drawing.Point(116, 108);
            this.ID_tb.Name = "ID_tb";
            this.ID_tb.Size = new System.Drawing.Size(100, 20);
            this.ID_tb.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TargetID_cb);
            this.groupBox2.Controls.Add(this.DevPair_bt);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.DevUnpair_bt);
            this.groupBox2.Controls.Add(this.GetScheduler_bt);
            this.groupBox2.Controls.Add(this.ManualModeOn_bt);
            this.groupBox2.Controls.Add(this.ManualModeOff_bt);
            this.groupBox2.Controls.Add(this.get_temp_bt);
            this.groupBox2.Controls.Add(this.ID_tb);
            this.groupBox2.Controls.Add(this.GetPCBTime_bt);
            this.groupBox2.Controls.Add(this.Power_tb);
            this.groupBox2.Controls.Add(this.GetPower_bt);
            this.groupBox2.Controls.Add(this.PCBTime_tb);
            this.groupBox2.Controls.Add(this.GetID_bt);
            this.groupBox2.Controls.Add(this.Temp_tb);
            this.groupBox2.Location = new System.Drawing.Point(12, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 262);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Functions Test";
            // 
            // ManualModeOff_bt
            // 
            this.ManualModeOff_bt.Location = new System.Drawing.Point(6, 135);
            this.ManualModeOff_bt.Name = "ManualModeOff_bt";
            this.ManualModeOff_bt.Size = new System.Drawing.Size(104, 23);
            this.ManualModeOff_bt.TabIndex = 8;
            this.ManualModeOff_bt.Text = "Manual Mode Off";
            this.ManualModeOff_bt.UseVisualStyleBackColor = true;
            this.ManualModeOff_bt.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManualModeOn_bt
            // 
            this.ManualModeOn_bt.Location = new System.Drawing.Point(6, 164);
            this.ManualModeOn_bt.Name = "ManualModeOn_bt";
            this.ManualModeOn_bt.Size = new System.Drawing.Size(104, 23);
            this.ManualModeOn_bt.TabIndex = 9;
            this.ManualModeOn_bt.Text = "Manual Mode On";
            this.ManualModeOn_bt.UseVisualStyleBackColor = true;
            this.ManualModeOn_bt.Click += new System.EventHandler(this.ManualModeOn_bt_Click);
            // 
            // GetScheduler_bt
            // 
            this.GetScheduler_bt.Location = new System.Drawing.Point(6, 193);
            this.GetScheduler_bt.Name = "GetScheduler_bt";
            this.GetScheduler_bt.Size = new System.Drawing.Size(104, 23);
            this.GetScheduler_bt.TabIndex = 10;
            this.GetScheduler_bt.Text = "Get Scheduler";
            this.GetScheduler_bt.UseVisualStyleBackColor = true;
            this.GetScheduler_bt.Click += new System.EventHandler(this.GetScheduler_bt_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.FoundID_rtext);
            this.groupBox3.Controls.Add(this.SearchL3_bt);
            this.groupBox3.Controls.Add(this.SearchL2_bt);
            this.groupBox3.Controls.Add(this.SearchL1_bt);
            this.groupBox3.Location = new System.Drawing.Point(351, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(421, 111);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Address Search";
            // 
            // SearchL1_bt
            // 
            this.SearchL1_bt.Location = new System.Drawing.Point(6, 19);
            this.SearchL1_bt.Name = "SearchL1_bt";
            this.SearchL1_bt.Size = new System.Drawing.Size(104, 23);
            this.SearchL1_bt.TabIndex = 0;
            this.SearchL1_bt.Text = "Search Level 1";
            this.SearchL1_bt.UseVisualStyleBackColor = true;
            this.SearchL1_bt.Click += new System.EventHandler(this.SearchL1_bt_Click);
            // 
            // SearchL2_bt
            // 
            this.SearchL2_bt.Location = new System.Drawing.Point(6, 48);
            this.SearchL2_bt.Name = "SearchL2_bt";
            this.SearchL2_bt.Size = new System.Drawing.Size(104, 23);
            this.SearchL2_bt.TabIndex = 1;
            this.SearchL2_bt.Text = "Search Level 2";
            this.SearchL2_bt.UseVisualStyleBackColor = true;
            this.SearchL2_bt.Click += new System.EventHandler(this.SearchL2_bt_Click);
            // 
            // SearchL3_bt
            // 
            this.SearchL3_bt.Location = new System.Drawing.Point(6, 77);
            this.SearchL3_bt.Name = "SearchL3_bt";
            this.SearchL3_bt.Size = new System.Drawing.Size(104, 23);
            this.SearchL3_bt.TabIndex = 2;
            this.SearchL3_bt.Text = "Search Level 3";
            this.SearchL3_bt.UseVisualStyleBackColor = true;
            this.SearchL3_bt.Click += new System.EventHandler(this.SearchL3_bt_Click);
            // 
            // DevUnpair_bt
            // 
            this.DevUnpair_bt.Location = new System.Drawing.Point(116, 135);
            this.DevUnpair_bt.Name = "DevUnpair_bt";
            this.DevUnpair_bt.Size = new System.Drawing.Size(104, 23);
            this.DevUnpair_bt.TabIndex = 3;
            this.DevUnpair_bt.Text = "Device Unpair";
            this.DevUnpair_bt.UseVisualStyleBackColor = true;
            this.DevUnpair_bt.Click += new System.EventHandler(this.DevUnpair_bt_Click);
            // 
            // DevPair_bt
            // 
            this.DevPair_bt.Location = new System.Drawing.Point(116, 164);
            this.DevPair_bt.Name = "DevPair_bt";
            this.DevPair_bt.Size = new System.Drawing.Size(104, 23);
            this.DevPair_bt.TabIndex = 4;
            this.DevPair_bt.Text = "Device Pair";
            this.DevPair_bt.UseVisualStyleBackColor = true;
            this.DevPair_bt.Click += new System.EventHandler(this.DevPair_bt_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SetIDToPCB_bt);
            this.groupBox4.Controls.Add(this.IDFromTime_tb);
            this.groupBox4.Controls.Add(this.GetIDFromTime_bt);
            this.groupBox4.Location = new System.Drawing.Point(12, 271);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(333, 55);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ID Setting";
            // 
            // GetIDFromTime_bt
            // 
            this.GetIDFromTime_bt.Location = new System.Drawing.Point(6, 19);
            this.GetIDFromTime_bt.Name = "GetIDFromTime_bt";
            this.GetIDFromTime_bt.Size = new System.Drawing.Size(104, 23);
            this.GetIDFromTime_bt.TabIndex = 0;
            this.GetIDFromTime_bt.Text = "Get ID From Time";
            this.GetIDFromTime_bt.UseVisualStyleBackColor = true;
            this.GetIDFromTime_bt.Click += new System.EventHandler(this.GetIDFromTime_bt_Click);
            // 
            // IDFromTime_tb
            // 
            this.IDFromTime_tb.Location = new System.Drawing.Point(116, 21);
            this.IDFromTime_tb.Name = "IDFromTime_tb";
            this.IDFromTime_tb.Size = new System.Drawing.Size(100, 20);
            this.IDFromTime_tb.TabIndex = 1;
            // 
            // SetIDToPCB_bt
            // 
            this.SetIDToPCB_bt.Location = new System.Drawing.Point(222, 19);
            this.SetIDToPCB_bt.Name = "SetIDToPCB_bt";
            this.SetIDToPCB_bt.Size = new System.Drawing.Size(104, 23);
            this.SetIDToPCB_bt.TabIndex = 2;
            this.SetIDToPCB_bt.Text = "Set ID To PCB";
            this.SetIDToPCB_bt.UseVisualStyleBackColor = true;
            this.SetIDToPCB_bt.Click += new System.EventHandler(this.SetIDToPCB_bt_Click);
            // 
            // FoundID_rtext
            // 
            this.FoundID_rtext.BackColor = System.Drawing.SystemColors.Window;
            this.FoundID_rtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FoundID_rtext.Location = new System.Drawing.Point(116, 19);
            this.FoundID_rtext.Name = "FoundID_rtext";
            this.FoundID_rtext.ReadOnly = true;
            this.FoundID_rtext.Size = new System.Drawing.Size(299, 81);
            this.FoundID_rtext.TabIndex = 5;
            this.FoundID_rtext.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Target ID";
            // 
            // TargetID_cb
            // 
            this.TargetID_cb.FormattingEnabled = true;
            this.TargetID_cb.Items.AddRange(new object[] {
            "FF FF FF FF"});
            this.TargetID_cb.Location = new System.Drawing.Point(64, 235);
            this.TargetID_cb.Name = "TargetID_cb";
            this.TargetID_cb.Size = new System.Drawing.Size(121, 21);
            this.TargetID_cb.TabIndex = 12;
            // 
            // SmartDimmerTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "SmartDimmerTT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartDimmer Test Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
            this.Load += new System.EventHandler(this.SmartDimmerTT_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.IO.Ports.SerialPort COMSerialPort;
        private System.ComponentModel.BackgroundWorker SerialListener;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox message_rtext;
        private System.Windows.Forms.Button get_temp_bt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ID_tb;
        private System.Windows.Forms.Button GetPCBTime_bt;
        private System.Windows.Forms.TextBox Power_tb;
        private System.Windows.Forms.Button GetPower_bt;
        private System.Windows.Forms.TextBox PCBTime_tb;
        private System.Windows.Forms.Button GetID_bt;
        private System.Windows.Forms.TextBox Temp_tb;
        private System.Windows.Forms.Button ManualModeOn_bt;
        private System.Windows.Forms.Button ManualModeOff_bt;
        private System.Windows.Forms.Button GetScheduler_bt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SearchL3_bt;
        private System.Windows.Forms.Button SearchL2_bt;
        private System.Windows.Forms.Button SearchL1_bt;
        private System.Windows.Forms.Button DevPair_bt;
        private System.Windows.Forms.Button DevUnpair_bt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button SetIDToPCB_bt;
        private System.Windows.Forms.TextBox IDFromTime_tb;
        private System.Windows.Forms.Button GetIDFromTime_bt;
        private System.Windows.Forms.RichTextBox FoundID_rtext;
        private System.Windows.Forms.ComboBox TargetID_cb;
        private System.Windows.Forms.Label label1;
    }
}

