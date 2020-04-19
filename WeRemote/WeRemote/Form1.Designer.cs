namespace WeRemote
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
            this.txtIP = new System.Windows.Forms.TextBox();
            this.Host = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.report = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rec_1 = new System.Windows.Forms.TextBox();
            this.rec_2 = new System.Windows.Forms.TextBox();
            this.rec_3 = new System.Windows.Forms.TextBox();
            this.rec_4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Clr = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.press_box2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(126, 36);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 22);
            this.txtIP.TabIndex = 0;
            this.txtIP.Text = "127.0.0.1";
            this.txtIP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Host
            // 
            this.Host.AutoSize = true;
            this.Host.Location = new System.Drawing.Point(75, 39);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(45, 17);
            this.Host.TabIndex = 1;
            this.Host.Text = "Host :";
            this.Host.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(321, 36);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 22);
            this.txtPort.TabIndex = 0;
            this.txtPort.Text = "8000";
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Location = new System.Drawing.Point(281, 39);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(34, 17);
            this.Port.TabIndex = 1;
            this.Port.Text = "Port";
            this.Port.Click += new System.EventHandler(this.label1_Click);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(498, 30);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(86, 35);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(619, 30);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(86, 35);
            this.Stop.TabIndex = 2;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // txtstatus
            // 
            this.txtstatus.Location = new System.Drawing.Point(78, 130);
            this.txtstatus.Multiline = true;
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtstatus.Size = new System.Drawing.Size(654, 114);
            this.txtstatus.TabIndex = 3;
            this.txtstatus.TextChanged += new System.EventHandler(this.txtstatus_TextChanged);
            // 
            // report
            // 
            this.report.AutoSize = true;
            this.report.Location = new System.Drawing.Point(78, 89);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(182, 17);
            this.report.TabIndex = 4;
            this.report.Text = "Press Start to start a server";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(611, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Created By Walid Mafuj";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "If Recieve";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Keypress";
            // 
            // rec_1
            // 
            this.rec_1.Location = new System.Drawing.Point(81, 310);
            this.rec_1.Name = "rec_1";
            this.rec_1.Size = new System.Drawing.Size(117, 22);
            this.rec_1.TabIndex = 0;
            this.rec_1.Text = "W";
            // 
            // rec_2
            // 
            this.rec_2.Location = new System.Drawing.Point(81, 350);
            this.rec_2.Name = "rec_2";
            this.rec_2.Size = new System.Drawing.Size(117, 22);
            this.rec_2.TabIndex = 0;
            this.rec_2.Text = "A";
            // 
            // rec_3
            // 
            this.rec_3.Location = new System.Drawing.Point(81, 394);
            this.rec_3.Name = "rec_3";
            this.rec_3.Size = new System.Drawing.Size(117, 22);
            this.rec_3.TabIndex = 0;
            this.rec_3.Text = "S";
            // 
            // rec_4
            // 
            this.rec_4.Location = new System.Drawing.Point(81, 440);
            this.rec_4.Name = "rec_4";
            this.rec_4.Size = new System.Drawing.Size(117, 22);
            this.rec_4.TabIndex = 0;
            this.rec_4.Text = "D";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "UP Arrow";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "----->";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "----->";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "----->";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 440);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "----->";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(281, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Left Arrow";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(281, 397);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Down Arrow ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(281, 440);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Right Arrow";
            // 
            // Clr
            // 
            this.Clr.Location = new System.Drawing.Point(597, 266);
            this.Clr.Name = "Clr";
            this.Clr.Size = new System.Drawing.Size(135, 48);
            this.Clr.TabIndex = 8;
            this.Clr.Text = "Clear";
            this.Clr.UseVisualStyleBackColor = true;
            this.Clr.Click += new System.EventHandler(this.Clr_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(393, 310);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // press_box2
            // 
            this.press_box2.Location = new System.Drawing.Point(397, 350);
            this.press_box2.Name = "press_box2";
            this.press_box2.Size = new System.Drawing.Size(117, 22);
            this.press_box2.TabIndex = 0;
            this.press_box2.TextChanged += new System.EventHandler(this.press_box2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 474);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Clr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.report);
            this.Controls.Add(this.txtstatus);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.rec_4);
            this.Controls.Add(this.rec_3);
            this.Controls.Add(this.press_box2);
            this.Controls.Add(this.rec_2);
            this.Controls.Add(this.rec_1);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label Host;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.Label report;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rec_1;
        private System.Windows.Forms.TextBox rec_2;
        private System.Windows.Forms.TextBox rec_3;
        private System.Windows.Forms.TextBox rec_4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Clr;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox press_box2;
    }
}

