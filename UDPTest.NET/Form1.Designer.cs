namespace UDPTest.NET
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numServerPort = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numSrcPort = new System.Windows.Forms.NumericUpDown();
            this.btnSend = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numDestPort = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDestIP = new System.Windows.Forms.TextBox();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numServerPort)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSrcPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDestPort)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numServerPort);
            this.groupBox1.Location = new System.Drawing.Point(3, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(174, 27);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(93, 27);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port:";
            // 
            // numServerPort
            // 
            this.numServerPort.Location = new System.Drawing.Point(6, 30);
            this.numServerPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numServerPort.Name = "numServerPort";
            this.numServerPort.Size = new System.Drawing.Size(81, 20);
            this.numServerPort.TabIndex = 0;
            this.numServerPort.Value = new decimal(new int[] {
            9910,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numSrcPort);
            this.groupBox2.Controls.Add(this.btnSend);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbMessage);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numDestPort);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbDestIP);
            this.groupBox2.Location = new System.Drawing.Point(3, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(619, 59);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "SrcPort:";
            // 
            // numSrcPort
            // 
            this.numSrcPort.Location = new System.Drawing.Point(223, 30);
            this.numSrcPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numSrcPort.Name = "numSrcPort";
            this.numSrcPort.Size = new System.Drawing.Size(81, 20);
            this.numSrcPort.TabIndex = 7;
            this.numSrcPort.Value = new decimal(new int[] {
            9900,
            0,
            0,
            0});
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(535, 27);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Message:";
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(310, 29);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(219, 20);
            this.tbMessage.TabIndex = 4;
            this.tbMessage.Text = "Hello!";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "DestPort:";
            // 
            // numDestPort
            // 
            this.numDestPort.Location = new System.Drawing.Point(151, 30);
            this.numDestPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numDestPort.Name = "numDestPort";
            this.numDestPort.Size = new System.Drawing.Size(66, 20);
            this.numDestPort.TabIndex = 2;
            this.numDestPort.Value = new decimal(new int[] {
            9910,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DestIP:";
            // 
            // tbDestIP
            // 
            this.tbDestIP.Location = new System.Drawing.Point(8, 29);
            this.tbDestIP.Name = "tbDestIP";
            this.tbDestIP.Size = new System.Drawing.Size(137, 20);
            this.tbDestIP.TabIndex = 0;
            this.tbDestIP.Text = "127.0.0.1";
            // 
            // lbLog
            // 
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(3, 142);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(619, 303);
            this.lbLog.TabIndex = 4;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(538, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 451);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "UDPTest.NET";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numServerPort)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSrcPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDestPort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numServerPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDestIP;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numDestPort;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numSrcPort;
    }
}

