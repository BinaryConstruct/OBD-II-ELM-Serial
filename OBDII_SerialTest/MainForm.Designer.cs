namespace OBDII_SerialTest
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.rxtxTB = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.echoCB = new System.Windows.Forms.CheckBox();
            this.commCloseBTN = new VistaButton();
            this.statusLBL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.portNameTB = new System.Windows.Forms.TextBox();
            this.baud348RB = new System.Windows.Forms.RadioButton();
            this.baud96RB = new System.Windows.Forms.RadioButton();
            this.commResetBTN = new VistaButton();
            this.settingsLBL = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.abortBTN = new VistaButton();
            this.commandTB = new System.Windows.Forms.TextBox();
            this.commSendBTN = new VistaButton();
            this.label3 = new System.Windows.Forms.Label();
            this.serialELM = new System.IO.Ports.SerialPort(this.components);
            this.checkSerialLine = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.outVoltageTB = new System.Windows.Forms.TextBox();
            this.rpmTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.monitorBTN = new VistaButton();
            this.headersCB = new System.Windows.Forms.CheckBox();
            this.vistaButton7 = new VistaButton();
            this.savelogBTN = new VistaButton();
            this.checkPid1BTN = new VistaButton();
            this.warmstartBTN = new VistaButton();
            this.elmTimer = new System.Windows.Forms.Timer(this.components);
            this.scanRpmCB = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rxtxTB
            // 
            this.rxtxTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rxtxTB.BackColor = System.Drawing.Color.Black;
            this.rxtxTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rxtxTB.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rxtxTB.ForeColor = System.Drawing.Color.Lime;
            this.rxtxTB.Location = new System.Drawing.Point(14, 224);
            this.rxtxTB.Name = "rxtxTB";
            this.rxtxTB.ReadOnly = true;
            this.rxtxTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rxtxTB.Size = new System.Drawing.Size(608, 269);
            this.rxtxTB.TabIndex = 0;
            this.rxtxTB.Text = "ELM Interface Test 1.0\n----------------------\n\n";
            this.rxtxTB.TextChanged += new System.EventHandler(this.rxtxTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Log";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.echoCB);
            this.panel1.Controls.Add(this.commCloseBTN);
            this.panel1.Controls.Add(this.statusLBL);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.portNameTB);
            this.panel1.Controls.Add(this.baud348RB);
            this.panel1.Controls.Add(this.baud96RB);
            this.panel1.Controls.Add(this.commResetBTN);
            this.panel1.Controls.Add(this.settingsLBL);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 129);
            this.panel1.TabIndex = 4;
            // 
            // echoCB
            // 
            this.echoCB.AutoSize = true;
            this.echoCB.Checked = true;
            this.echoCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.echoCB.Location = new System.Drawing.Point(6, 100);
            this.echoCB.Name = "echoCB";
            this.echoCB.Size = new System.Drawing.Size(54, 19);
            this.echoCB.TabIndex = 8;
            this.echoCB.Text = "Echo";
            this.echoCB.UseVisualStyleBackColor = true;
            this.echoCB.CheckedChanged += new System.EventHandler(this.echoCB_CheckedChanged);
            // 
            // commCloseBTN
            // 
            this.commCloseBTN.BackColor = System.Drawing.Color.Transparent;
            this.commCloseBTN.ButtonText = "Close Port";
            this.commCloseBTN.CornerRadius = 2;
            this.commCloseBTN.GlowColor = System.Drawing.Color.Silver;
            this.commCloseBTN.Location = new System.Drawing.Point(162, 100);
            this.commCloseBTN.Name = "commCloseBTN";
            this.commCloseBTN.Size = new System.Drawing.Size(132, 24);
            this.commCloseBTN.TabIndex = 7;
            this.commCloseBTN.Click += new System.EventHandler(this.commCloseBTN_Click);
            // 
            // statusLBL
            // 
            this.statusLBL.AutoSize = true;
            this.statusLBL.ForeColor = System.Drawing.Color.Red;
            this.statusLBL.Location = new System.Drawing.Point(160, 22);
            this.statusLBL.Name = "statusLBL";
            this.statusLBL.Size = new System.Drawing.Size(98, 15);
            this.statusLBL.TabIndex = 6;
            this.statusLBL.Text = "Not Connected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(159, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Status";
            // 
            // portNameTB
            // 
            this.portNameTB.BackColor = System.Drawing.Color.Black;
            this.portNameTB.ForeColor = System.Drawing.Color.Lime;
            this.portNameTB.Location = new System.Drawing.Point(6, 69);
            this.portNameTB.Name = "portNameTB";
            this.portNameTB.Size = new System.Drawing.Size(95, 21);
            this.portNameTB.TabIndex = 4;
            this.portNameTB.Text = "COM1";
            this.portNameTB.TextChanged += new System.EventHandler(this.portNameTB_TextChanged);
            // 
            // baud348RB
            // 
            this.baud348RB.AutoSize = true;
            this.baud348RB.Checked = true;
            this.baud348RB.Location = new System.Drawing.Point(6, 44);
            this.baud348RB.Name = "baud348RB";
            this.baud348RB.Size = new System.Drawing.Size(95, 19);
            this.baud348RB.TabIndex = 3;
            this.baud348RB.TabStop = true;
            this.baud348RB.Text = "34800 Baud";
            this.baud348RB.UseVisualStyleBackColor = true;
            this.baud348RB.CheckedChanged += new System.EventHandler(this.baud348RB_CheckedChanged);
            // 
            // baud96RB
            // 
            this.baud96RB.AutoSize = true;
            this.baud96RB.Location = new System.Drawing.Point(6, 19);
            this.baud96RB.Name = "baud96RB";
            this.baud96RB.Size = new System.Drawing.Size(88, 19);
            this.baud96RB.TabIndex = 2;
            this.baud96RB.Text = "9600 Baud";
            this.baud96RB.UseVisualStyleBackColor = true;
            // 
            // commResetBTN
            // 
            this.commResetBTN.BackColor = System.Drawing.Color.Transparent;
            this.commResetBTN.ButtonText = "Reset ELM";
            this.commResetBTN.CornerRadius = 2;
            this.commResetBTN.GlowColor = System.Drawing.Color.Silver;
            this.commResetBTN.Location = new System.Drawing.Point(162, 73);
            this.commResetBTN.Name = "commResetBTN";
            this.commResetBTN.Size = new System.Drawing.Size(132, 24);
            this.commResetBTN.TabIndex = 1;
            this.commResetBTN.Click += new System.EventHandler(this.commResetBTN_Click);
            // 
            // settingsLBL
            // 
            this.settingsLBL.AutoSize = true;
            this.settingsLBL.ForeColor = System.Drawing.Color.Lime;
            this.settingsLBL.Location = new System.Drawing.Point(5, 1);
            this.settingsLBL.Name = "settingsLBL";
            this.settingsLBL.Size = new System.Drawing.Size(63, 15);
            this.settingsLBL.TabIndex = 0;
            this.settingsLBL.Text = "Settings";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.scanRpmCB);
            this.panel2.Controls.Add(this.abortBTN);
            this.panel2.Controls.Add(this.monitorBTN);
            this.panel2.Controls.Add(this.commandTB);
            this.panel2.Controls.Add(this.headersCB);
            this.panel2.Controls.Add(this.vistaButton7);
            this.panel2.Controls.Add(this.commSendBTN);
            this.panel2.Controls.Add(this.savelogBTN);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.checkPid1BTN);
            this.panel2.Controls.Add(this.warmstartBTN);
            this.panel2.Location = new System.Drawing.Point(323, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 192);
            this.panel2.TabIndex = 5;
            // 
            // abortBTN
            // 
            this.abortBTN.BackColor = System.Drawing.Color.Transparent;
            this.abortBTN.BaseColor = System.Drawing.Color.Red;
            this.abortBTN.ButtonText = "Abort";
            this.abortBTN.CornerRadius = 2;
            this.abortBTN.GlowColor = System.Drawing.Color.Silver;
            this.abortBTN.Location = new System.Drawing.Point(152, 45);
            this.abortBTN.Name = "abortBTN";
            this.abortBTN.Size = new System.Drawing.Size(143, 24);
            this.abortBTN.TabIndex = 13;
            this.abortBTN.Click += new System.EventHandler(this.abortBTN_Click);
            // 
            // commandTB
            // 
            this.commandTB.BackColor = System.Drawing.Color.Black;
            this.commandTB.ForeColor = System.Drawing.Color.Lime;
            this.commandTB.Location = new System.Drawing.Point(4, 18);
            this.commandTB.Name = "commandTB";
            this.commandTB.Size = new System.Drawing.Size(291, 21);
            this.commandTB.TabIndex = 5;
            this.commandTB.Text = "AT ";
            this.commandTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.commandTB_KeyPress);
            // 
            // commSendBTN
            // 
            this.commSendBTN.BackColor = System.Drawing.Color.Transparent;
            this.commSendBTN.ButtonText = "Send Command";
            this.commSendBTN.CornerRadius = 2;
            this.commSendBTN.GlowColor = System.Drawing.Color.Silver;
            this.commSendBTN.Location = new System.Drawing.Point(4, 45);
            this.commSendBTN.Name = "commSendBTN";
            this.commSendBTN.Size = new System.Drawing.Size(111, 24);
            this.commSendBTN.TabIndex = 5;
            this.commSendBTN.Click += new System.EventHandler(this.commSendBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(5, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Commands";
            // 
            // serialELM
            // 
            this.serialELM.BaudRate = 38400;
            this.serialELM.DiscardNull = true;
            this.serialELM.ReceivedBytesThreshold = 2;
            this.serialELM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialELM_DataRecieved);
            this.serialELM.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialELM_ErrorReceived);
            // 
            // checkSerialLine
            // 
            this.checkSerialLine.Enabled = true;
            this.checkSerialLine.Interval = 2000;
            this.checkSerialLine.Tick += new System.EventHandler(this.checkSerialLine_Tick);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(18, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Battery Voltage";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // outVoltageTB
            // 
            this.outVoltageTB.BackColor = System.Drawing.Color.Black;
            this.outVoltageTB.ForeColor = System.Drawing.Color.Lime;
            this.outVoltageTB.Location = new System.Drawing.Point(167, 147);
            this.outVoltageTB.Name = "outVoltageTB";
            this.outVoltageTB.ReadOnly = true;
            this.outVoltageTB.Size = new System.Drawing.Size(147, 21);
            this.outVoltageTB.TabIndex = 6;
            this.outVoltageTB.Text = "0.0V";
            this.outVoltageTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.outVoltageTB.MouseLeave += new System.EventHandler(this.outTB_MouseLeave);
            this.outVoltageTB.Click += new System.EventHandler(this.outVoltageTB_Click);
            this.outVoltageTB.MouseEnter += new System.EventHandler(this.outTB_MouseEnter);
            // 
            // rpmTB
            // 
            this.rpmTB.BackColor = System.Drawing.Color.Black;
            this.rpmTB.ForeColor = System.Drawing.Color.Lime;
            this.rpmTB.Location = new System.Drawing.Point(167, 174);
            this.rpmTB.Name = "rpmTB";
            this.rpmTB.ReadOnly = true;
            this.rpmTB.Size = new System.Drawing.Size(147, 21);
            this.rpmTB.TabIndex = 13;
            this.rpmTB.Text = "0 RPM";
            this.rpmTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(18, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 21);
            this.label11.TabIndex = 14;
            this.label11.Text = "RPM";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // monitorBTN
            // 
            this.monitorBTN.BackColor = System.Drawing.Color.Transparent;
            this.monitorBTN.ButtonText = "Monitor ALL";
            this.monitorBTN.CornerRadius = 2;
            this.monitorBTN.GlowColor = System.Drawing.Color.Silver;
            this.monitorBTN.Location = new System.Drawing.Point(3, 103);
            this.monitorBTN.Name = "monitorBTN";
            this.monitorBTN.Size = new System.Drawing.Size(137, 24);
            this.monitorBTN.TabIndex = 15;
            this.monitorBTN.Click += new System.EventHandler(this.monitorBTN_Click);
            // 
            // headersCB
            // 
            this.headersCB.AutoSize = true;
            this.headersCB.Location = new System.Drawing.Point(3, 78);
            this.headersCB.Name = "headersCB";
            this.headersCB.Size = new System.Drawing.Size(110, 19);
            this.headersCB.TabIndex = 14;
            this.headersCB.Text = "Show Headers";
            this.headersCB.UseVisualStyleBackColor = true;
            this.headersCB.CheckedChanged += new System.EventHandler(this.headersCB_CheckedChanged);
            // 
            // vistaButton7
            // 
            this.vistaButton7.BackColor = System.Drawing.Color.Transparent;
            this.vistaButton7.ButtonText = "Scan";
            this.vistaButton7.CornerRadius = 2;
            this.vistaButton7.GlowColor = System.Drawing.Color.Silver;
            this.vistaButton7.Location = new System.Drawing.Point(3, 133);
            this.vistaButton7.Name = "vistaButton7";
            this.vistaButton7.Size = new System.Drawing.Size(137, 24);
            this.vistaButton7.TabIndex = 13;
            this.vistaButton7.Click += new System.EventHandler(this.vistaButton7_Click);
            // 
            // savelogBTN
            // 
            this.savelogBTN.BackColor = System.Drawing.Color.Transparent;
            this.savelogBTN.ButtonText = "Save Log";
            this.savelogBTN.CornerRadius = 2;
            this.savelogBTN.GlowColor = System.Drawing.Color.Silver;
            this.savelogBTN.Location = new System.Drawing.Point(3, 161);
            this.savelogBTN.Name = "savelogBTN";
            this.savelogBTN.Size = new System.Drawing.Size(286, 24);
            this.savelogBTN.TabIndex = 12;
            this.savelogBTN.Click += new System.EventHandler(this.savelogBTN_Click);
            // 
            // checkPid1BTN
            // 
            this.checkPid1BTN.BackColor = System.Drawing.Color.Transparent;
            this.checkPid1BTN.ButtonText = "Check PIDs";
            this.checkPid1BTN.CornerRadius = 2;
            this.checkPid1BTN.GlowColor = System.Drawing.Color.Silver;
            this.checkPid1BTN.Location = new System.Drawing.Point(146, 133);
            this.checkPid1BTN.Name = "checkPid1BTN";
            this.checkPid1BTN.Size = new System.Drawing.Size(143, 24);
            this.checkPid1BTN.TabIndex = 9;
            this.checkPid1BTN.Click += new System.EventHandler(this.checkPid1BTN_Click);
            // 
            // warmstartBTN
            // 
            this.warmstartBTN.BackColor = System.Drawing.Color.Transparent;
            this.warmstartBTN.ButtonText = "WARM RESTART";
            this.warmstartBTN.CornerRadius = 2;
            this.warmstartBTN.GlowColor = System.Drawing.Color.Silver;
            this.warmstartBTN.Location = new System.Drawing.Point(146, 103);
            this.warmstartBTN.Name = "warmstartBTN";
            this.warmstartBTN.Size = new System.Drawing.Size(143, 24);
            this.warmstartBTN.TabIndex = 7;
            this.warmstartBTN.Click += new System.EventHandler(this.warmstartBTN_Click);
            // 
            // elmTimer
            // 
            this.elmTimer.Interval = 60;
            this.elmTimer.Tick += new System.EventHandler(this.elmTimer_Tick);
            // 
            // scanRpmCB
            // 
            this.scanRpmCB.AutoSize = true;
            this.scanRpmCB.Location = new System.Drawing.Point(147, 78);
            this.scanRpmCB.Name = "scanRpmCB";
            this.scanRpmCB.Size = new System.Drawing.Size(82, 19);
            this.scanRpmCB.TabIndex = 21;
            this.scanRpmCB.Text = "Scan RPM";
            this.scanRpmCB.UseVisualStyleBackColor = true;
            this.scanRpmCB.CheckedChanged += new System.EventHandler(this.scanRpmCB_CheckedChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "obd_log.txt";
            this.saveFileDialog1.Filter = "Text Files|*.txt";
            this.saveFileDialog1.Title = "Save Log File";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(631, 505);
            this.Controls.Add(this.rpmTB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.outVoltageTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rxtxTB);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(8, 450);
            this.Name = "MainForm";
            this.Text = "ODB-II Serial Interface";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rxtxTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label settingsLBL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox portNameTB;
        private System.Windows.Forms.RadioButton baud348RB;
        private System.Windows.Forms.RadioButton baud96RB;
        private VistaButton commResetBTN;
        private System.IO.Ports.SerialPort serialELM;
        private System.Windows.Forms.TextBox commandTB;
        private VistaButton commSendBTN;
        private System.Windows.Forms.Label statusLBL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer checkSerialLine;
        private VistaButton commCloseBTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox outVoltageTB;
        private System.Windows.Forms.TextBox rpmTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox echoCB;
        private System.Windows.Forms.CheckBox headersCB;
        private VistaButton vistaButton7;
        private VistaButton savelogBTN;
        private VistaButton checkPid1BTN;
        private VistaButton warmstartBTN;
        private VistaButton monitorBTN;
        private System.Windows.Forms.Timer elmTimer;
        private VistaButton abortBTN;
        private System.Windows.Forms.CheckBox scanRpmCB;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

