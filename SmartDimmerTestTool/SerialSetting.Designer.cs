namespace SmartDimmerTestTool
{
    partial class SerialSetting
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
            this.Ports_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Baudrate_cb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DataBits_cb = new System.Windows.Forms.ComboBox();
            this.StopBit_cb = new System.Windows.Forms.ComboBox();
            this.Parity_cb = new System.Windows.Forms.ComboBox();
            this.SerialConnect_bt = new System.Windows.Forms.Button();
            this.SerialCancel_bt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ports_cb
            // 
            this.Ports_cb.FormattingEnabled = true;
            this.Ports_cb.Location = new System.Drawing.Point(71, 12);
            this.Ports_cb.Name = "Ports_cb";
            this.Ports_cb.Size = new System.Drawing.Size(121, 21);
            this.Ports_cb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baudrate";
            // 
            // Baudrate_cb
            // 
            this.Baudrate_cb.FormattingEnabled = true;
            this.Baudrate_cb.Items.AddRange(new object[] {
            "1200",
            "9600",
            "19200",
            "38400",
            "115200",
            "256000"});
            this.Baudrate_cb.Location = new System.Drawing.Point(71, 39);
            this.Baudrate_cb.Name = "Baudrate_cb";
            this.Baudrate_cb.Size = new System.Drawing.Size(121, 21);
            this.Baudrate_cb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data Bit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Stop Bit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Parity";
            // 
            // DataBits_cb
            // 
            this.DataBits_cb.FormattingEnabled = true;
            this.DataBits_cb.Location = new System.Drawing.Point(71, 66);
            this.DataBits_cb.Name = "DataBits_cb";
            this.DataBits_cb.Size = new System.Drawing.Size(121, 21);
            this.DataBits_cb.TabIndex = 7;
            // 
            // StopBit_cb
            // 
            this.StopBit_cb.FormattingEnabled = true;
            this.StopBit_cb.Items.AddRange(new object[] {
            "None",
            "One",
            "One Point Five",
            "Two"});
            this.StopBit_cb.Location = new System.Drawing.Point(71, 93);
            this.StopBit_cb.Name = "StopBit_cb";
            this.StopBit_cb.Size = new System.Drawing.Size(121, 21);
            this.StopBit_cb.TabIndex = 8;
            // 
            // Parity_cb
            // 
            this.Parity_cb.FormattingEnabled = true;
            this.Parity_cb.Items.AddRange(new object[] {
            "Even",
            "Mark",
            "None",
            "Odd",
            "Space"});
            this.Parity_cb.Location = new System.Drawing.Point(71, 120);
            this.Parity_cb.Name = "Parity_cb";
            this.Parity_cb.Size = new System.Drawing.Size(121, 21);
            this.Parity_cb.TabIndex = 9;
            // 
            // SerialConnect_bt
            // 
            this.SerialConnect_bt.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SerialConnect_bt.Location = new System.Drawing.Point(12, 158);
            this.SerialConnect_bt.Name = "SerialConnect_bt";
            this.SerialConnect_bt.Size = new System.Drawing.Size(75, 23);
            this.SerialConnect_bt.TabIndex = 10;
            this.SerialConnect_bt.Text = "OK";
            this.SerialConnect_bt.UseVisualStyleBackColor = true;
            this.SerialConnect_bt.Click += new System.EventHandler(this.SerialConnect_bt_Click);
            // 
            // SerialCancel_bt
            // 
            this.SerialCancel_bt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SerialCancel_bt.Location = new System.Drawing.Point(117, 158);
            this.SerialCancel_bt.Name = "SerialCancel_bt";
            this.SerialCancel_bt.Size = new System.Drawing.Size(75, 23);
            this.SerialCancel_bt.TabIndex = 11;
            this.SerialCancel_bt.Text = "Cancel";
            this.SerialCancel_bt.UseVisualStyleBackColor = true;
            // 
            // SerialSetting
            // 
            this.AcceptButton = this.SerialConnect_bt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.SerialCancel_bt;
            this.ClientSize = new System.Drawing.Size(209, 192);
            this.Controls.Add(this.SerialCancel_bt);
            this.Controls.Add(this.SerialConnect_bt);
            this.Controls.Add(this.Parity_cb);
            this.Controls.Add(this.StopBit_cb);
            this.Controls.Add(this.DataBits_cb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Baudrate_cb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ports_cb);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(225, 230);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(225, 230);
            this.Name = "SerialSetting";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Serial Setting";
            this.Load += new System.EventHandler(this.SerialSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Ports_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Baudrate_cb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox DataBits_cb;
        private System.Windows.Forms.ComboBox StopBit_cb;
        private System.Windows.Forms.ComboBox Parity_cb;
        private System.Windows.Forms.Button SerialConnect_bt;
        private System.Windows.Forms.Button SerialCancel_bt;
    }
}