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
            this.commCloseBTN = new bcLib.VistaButton();
            this.statusLBL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.portNameTB = new System.Windows.Forms.TextBox();
            this.baud348RB = new System.Windows.Forms.RadioButton();
            this.baud96RB = new System.Windows.Forms.RadioButton();
            this.commResetBTN = new bcLib.VistaButton();
            this.settingsLBL = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.abortBTN = new bcLib.VistaButton();
            this.testPIDClassBTN = new bcLib.VistaButton();
            this.testParseBTN = new bcLib.VistaButton();
            this.crcBTN = new bcLib.VistaButton();
            this.commandTB = new System.Windows.Forms.TextBox();
            this.commSendBTN = new bcLib.VistaButton();
            this.label3 = new System.Windows.Forms.Label();
            this.serialELM = new System.IO.Ports.SerialPort(this.components);
            this.checkSerialLine = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.outVoltageTB = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.monitorBTN = new bcLib.VistaButton();
            this.headersCB = new System.Windows.Forms.CheckBox();
            this.vistaButton7 = new bcLib.VistaButton();
            this.savelogBTN = new bcLib.VistaButton();
            this.checkPid1BTN = new bcLib.VistaButton();
            this.warmstartBTN = new bcLib.VistaButton();
            this.label8 = new System.Windows.Forms.Label();
            this.elmTimer = new System.Windows.Forms.Timer(this.components);
            this.scanRpmCB = new System.Windows.Forms.CheckBox();
            this.aGauge1 = new AGaugeClass.AGauge();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rxtxTB
            // 
            this.rxtxTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.rxtxTB.BackColor = System.Drawing.Color.Black;
            this.rxtxTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rxtxTB.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rxtxTB.ForeColor = System.Drawing.Color.Lime;
            this.rxtxTB.Location = new System.Drawing.Point(14, 163);
            this.rxtxTB.Name = "rxtxTB";
            this.rxtxTB.ReadOnly = true;
            this.rxtxTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rxtxTB.Size = new System.Drawing.Size(300, 333);
            this.rxtxTB.TabIndex = 0;
            this.rxtxTB.Text = "ELM Interface Test 1.0\n----------------------\n\n";
            this.rxtxTB.TextChanged += new System.EventHandler(this.rxtxTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Stream";
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
            this.commResetBTN.Location = new System.Drawing.Point(163, 73);
            this.commResetBTN.Name = "commResetBTN";
            this.commResetBTN.Size = new System.Drawing.Size(131, 24);
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
            this.panel2.Controls.Add(this.abortBTN);
            this.panel2.Controls.Add(this.testPIDClassBTN);
            this.panel2.Controls.Add(this.testParseBTN);
            this.panel2.Controls.Add(this.crcBTN);
            this.panel2.Controls.Add(this.commandTB);
            this.panel2.Controls.Add(this.commSendBTN);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(323, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 129);
            this.panel2.TabIndex = 5;
            // 
            // abortBTN
            // 
            this.abortBTN.BackColor = System.Drawing.Color.Transparent;
            this.abortBTN.BaseColor = System.Drawing.Color.Red;
            this.abortBTN.ButtonText = "Abort";
            this.abortBTN.CornerRadius = 2;
            this.abortBTN.GlowColor = System.Drawing.Color.Silver;
            this.abortBTN.Location = new System.Drawing.Point(151, 13);
            this.abortBTN.Name = "abortBTN";
            this.abortBTN.Size = new System.Drawing.Size(143, 24);
            this.abortBTN.TabIndex = 13;
            this.abortBTN.Click += new System.EventHandler(this.abortBTN_Click);
            // 
            // testPIDClassBTN
            // 
            this.testPIDClassBTN.BackColor = System.Drawing.Color.Transparent;
            this.testPIDClassBTN.ButtonText = "Test PID Class";
            this.testPIDClassBTN.CornerRadius = 2;
            this.testPIDClassBTN.GlowColor = System.Drawing.Color.Silver;
            this.testPIDClassBTN.Location = new System.Drawing.Point(151, 44);
            this.testPIDClassBTN.Name = "testPIDClassBTN";
            this.testPIDClassBTN.Size = new System.Drawing.Size(143, 24);
            this.testPIDClassBTN.TabIndex = 12;
            this.testPIDClassBTN.Click += new System.EventHandler(this.testPIDClassBTN_Click);
            // 
            // testParseBTN
            // 
            this.testParseBTN.BackColor = System.Drawing.Color.Transparent;
            this.testParseBTN.ButtonText = "Test Parser";
            this.testParseBTN.CornerRadius = 2;
            this.testParseBTN.GlowColor = System.Drawing.Color.Silver;
            this.testParseBTN.Location = new System.Drawing.Point(3, 43);
            this.testParseBTN.Name = "testParseBTN";
            this.testParseBTN.Size = new System.Drawing.Size(111, 24);
            this.testParseBTN.TabIndex = 11;
            this.testParseBTN.Click += new System.EventHandler(this.testParseBTN_Click);
            // 
            // crcBTN
            // 
            this.crcBTN.BackColor = System.Drawing.Color.Transparent;
            this.crcBTN.ButtonText = "Calculate CRC";
            this.crcBTN.CornerRadius = 2;
            this.crcBTN.GlowColor = System.Drawing.Color.Silver;
            this.crcBTN.Location = new System.Drawing.Point(151, 100);
            this.crcBTN.Name = "crcBTN";
            this.crcBTN.Size = new System.Drawing.Size(143, 24);
            this.crcBTN.TabIndex = 10;
            this.crcBTN.Click += new System.EventHandler(this.crcBTN_Click);
            // 
            // commandTB
            // 
            this.commandTB.BackColor = System.Drawing.Color.Black;
            this.commandTB.ForeColor = System.Drawing.Color.Lime;
            this.commandTB.Location = new System.Drawing.Point(3, 73);
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
            this.commSendBTN.Location = new System.Drawing.Point(3, 100);
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
            this.label4.Location = new System.Drawing.Point(327, 163);
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
            this.outVoltageTB.Location = new System.Drawing.Point(476, 163);
            this.outVoltageTB.Name = "outVoltageTB";
            this.outVoltageTB.ReadOnly = true;
            this.outVoltageTB.Size = new System.Drawing.Size(147, 21);
            this.outVoltageTB.TabIndex = 6;
            this.outVoltageTB.Text = "0.0V";
            this.outVoltageTB.MouseLeave += new System.EventHandler(this.outTB_MouseLeave);
            this.outVoltageTB.Click += new System.EventHandler(this.outVoltageTB_Click);
            this.outVoltageTB.MouseEnter += new System.EventHandler(this.outTB_MouseEnter);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Black;
            this.textBox2.ForeColor = System.Drawing.Color.Lime;
            this.textBox2.Location = new System.Drawing.Point(476, 190);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(147, 21);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "0%";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(330, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Throttle";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Black;
            this.textBox3.ForeColor = System.Drawing.Color.Lime;
            this.textBox3.Location = new System.Drawing.Point(476, 244);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(147, 21);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "0 KPa";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(327, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "MAP KPa";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Black;
            this.textBox4.ForeColor = System.Drawing.Color.Lime;
            this.textBox4.Location = new System.Drawing.Point(476, 217);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(147, 21);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "14.68";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(327, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Commanded AFR";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(327, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Fuel Mode";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Black;
            this.textBox7.ForeColor = System.Drawing.Color.Lime;
            this.textBox7.Location = new System.Drawing.Point(476, 298);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(147, 21);
            this.textBox7.TabIndex = 16;
            this.textBox7.Text = "0 MPH";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(327, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 21);
            this.label10.TabIndex = 15;
            this.label10.Text = "Speed MPH";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.Black;
            this.textBox8.ForeColor = System.Drawing.Color.Lime;
            this.textBox8.Location = new System.Drawing.Point(476, 271);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(147, 21);
            this.textBox8.TabIndex = 13;
            this.textBox8.Text = "0 RPM";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(327, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 21);
            this.label11.TabIndex = 14;
            this.label11.Text = "RPM";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Black;
            this.textBox6.ForeColor = System.Drawing.Color.Lime;
            this.textBox6.Location = new System.Drawing.Point(476, 325);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(147, 21);
            this.textBox6.TabIndex = 17;
            this.textBox6.Text = "Open Loop";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.monitorBTN);
            this.panel3.Controls.Add(this.headersCB);
            this.panel3.Controls.Add(this.vistaButton7);
            this.panel3.Controls.Add(this.savelogBTN);
            this.panel3.Controls.Add(this.checkPid1BTN);
            this.panel3.Controls.Add(this.warmstartBTN);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(323, 352);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 144);
            this.panel3.TabIndex = 19;
            // 
            // monitorBTN
            // 
            this.monitorBTN.BackColor = System.Drawing.Color.Transparent;
            this.monitorBTN.ButtonText = "Monitor ALL";
            this.monitorBTN.CornerRadius = 2;
            this.monitorBTN.GlowColor = System.Drawing.Color.Silver;
            this.monitorBTN.Location = new System.Drawing.Point(8, 49);
            this.monitorBTN.Name = "monitorBTN";
            this.monitorBTN.Size = new System.Drawing.Size(137, 24);
            this.monitorBTN.TabIndex = 15;
            this.monitorBTN.Click += new System.EventHandler(this.monitorBTN_Click);
            // 
            // headersCB
            // 
            this.headersCB.AutoSize = true;
            this.headersCB.Location = new System.Drawing.Point(8, 24);
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
            this.vistaButton7.Location = new System.Drawing.Point(151, 109);
            this.vistaButton7.Name = "vistaButton7";
            this.vistaButton7.Size = new System.Drawing.Size(143, 24);
            this.vistaButton7.TabIndex = 13;
            this.vistaButton7.Click += new System.EventHandler(this.vistaButton7_Click);
            // 
            // savelogBTN
            // 
            this.savelogBTN.BackColor = System.Drawing.Color.Transparent;
            this.savelogBTN.ButtonText = "Save Log";
            this.savelogBTN.CornerRadius = 2;
            this.savelogBTN.GlowColor = System.Drawing.Color.Silver;
            this.savelogBTN.Location = new System.Drawing.Point(8, 109);
            this.savelogBTN.Name = "savelogBTN";
            this.savelogBTN.Size = new System.Drawing.Size(137, 24);
            this.savelogBTN.TabIndex = 12;
            this.savelogBTN.Click += new System.EventHandler(this.savelogBTN_Click);
            // 
            // checkPid1BTN
            // 
            this.checkPid1BTN.BackColor = System.Drawing.Color.Transparent;
            this.checkPid1BTN.ButtonText = "Check PIDs";
            this.checkPid1BTN.CornerRadius = 2;
            this.checkPid1BTN.GlowColor = System.Drawing.Color.Silver;
            this.checkPid1BTN.Location = new System.Drawing.Point(151, 49);
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
            this.warmstartBTN.Location = new System.Drawing.Point(151, 19);
            this.warmstartBTN.Name = "warmstartBTN";
            this.warmstartBTN.Size = new System.Drawing.Size(143, 24);
            this.warmstartBTN.TabIndex = 7;
            this.warmstartBTN.Click += new System.EventHandler(this.warmstartBTN_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(5, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "Utilities";
            // 
            // elmTimer
            // 
            this.elmTimer.Interval = 60;
            this.elmTimer.Tick += new System.EventHandler(this.elmTimer_Tick);
            // 
            // scanRpmCB
            // 
            this.scanRpmCB.AutoSize = true;
            this.scanRpmCB.Location = new System.Drawing.Point(648, 246);
            this.scanRpmCB.Name = "scanRpmCB";
            this.scanRpmCB.Size = new System.Drawing.Size(82, 19);
            this.scanRpmCB.TabIndex = 21;
            this.scanRpmCB.Text = "Scan RPM";
            this.scanRpmCB.UseVisualStyleBackColor = true;
            this.scanRpmCB.CheckedChanged += new System.EventHandler(this.scanRpmCB_CheckedChanged);
            // 
            // aGauge1
            // 
            this.aGauge1.BaseArcColor = System.Drawing.Color.Gray;
            this.aGauge1.BaseArcRadius = 80;
            this.aGauge1.BaseArcStart = 135;
            this.aGauge1.BaseArcSweep = 270;
            this.aGauge1.BaseArcWidth = 2;
            this.aGauge1.Cap_Idx = ((byte)(1));
            this.aGauge1.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge1.CapPosition = new System.Drawing.Point(85, 160);
            this.aGauge1.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(85, 160),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge1.CapsText = new string[] {
        "",
        "RPM",
        "",
        "",
        ""};
            this.aGauge1.CapText = "RPM";
            this.aGauge1.Center = new System.Drawing.Point(125, 125);
            this.aGauge1.Font = new System.Drawing.Font("Arial Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aGauge1.Location = new System.Drawing.Point(629, 15);
            this.aGauge1.MaxValue = 6000F;
            this.aGauge1.MinValue = 0F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.NeedleColor1 = AGaugeClass.AGauge.NeedleColorEnum.Red;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.Red;
            this.aGauge1.NeedleRadius = 70;
            this.aGauge1.NeedleType = 2;
            this.aGauge1.NeedleWidth = 25;
            this.aGauge1.Range_Idx = ((byte)(1));
            this.aGauge1.RangeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.aGauge1.RangeEnabled = true;
            this.aGauge1.RangeEndValue = 4500F;
            this.aGauge1.RangeInnerRadius = 70;
            this.aGauge1.RangeOuterRadius = 80;
            this.aGauge1.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control};
            this.aGauge1.RangesEnabled = new bool[] {
        true,
        true,
        true,
        true,
        false};
            this.aGauge1.RangesEndValue = new float[] {
        600F,
        4500F,
        5000F,
        6000F,
        0F};
            this.aGauge1.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.aGauge1.RangesOuterRadius = new int[] {
        80,
        80,
        80,
        80,
        80};
            this.aGauge1.RangesStartValue = new float[] {
        0F,
        300F,
        4500F,
        5000F,
        0F};
            this.aGauge1.RangeStartValue = 300F;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesInterInnerRadius = 73;
            this.aGauge1.ScaleLinesInterOuterRadius = 80;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMajorInnerRadius = 70;
            this.aGauge1.ScaleLinesMajorOuterRadius = 80;
            this.aGauge1.ScaleLinesMajorStepValue = 1000F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMinorInnerRadius = 75;
            this.aGauge1.ScaleLinesMinorNumOf = 10;
            this.aGauge1.ScaleLinesMinorOuterRadius = 80;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.White;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 100;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 0;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Size = new System.Drawing.Size(253, 209);
            this.aGauge1.TabIndex = 20;
            this.aGauge1.Text = "aGauge1";
            this.aGauge1.Value = 2000F;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(908, 505);
            this.Controls.Add(this.scanRpmCB);
            this.Controls.Add(this.aGauge1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.outVoltageTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rxtxTB);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(8, 450);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ODB-II Serial Interface";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private bcLib.VistaButton commResetBTN;
        private System.IO.Ports.SerialPort serialELM;
        private System.Windows.Forms.TextBox commandTB;
        private bcLib.VistaButton commSendBTN;
        private System.Windows.Forms.Label statusLBL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer checkSerialLine;
        private bcLib.VistaButton commCloseBTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox outVoltageTB;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox echoCB;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox headersCB;
        private bcLib.VistaButton vistaButton7;
        private bcLib.VistaButton savelogBTN;
        private bcLib.VistaButton checkPid1BTN;
        private bcLib.VistaButton warmstartBTN;
        private System.Windows.Forms.Label label8;
        private bcLib.VistaButton monitorBTN;
        private bcLib.VistaButton crcBTN;
        private System.Windows.Forms.Timer elmTimer;
        private bcLib.VistaButton testParseBTN;
        private bcLib.VistaButton testPIDClassBTN;
        private bcLib.VistaButton abortBTN;
        private AGaugeClass.AGauge aGauge1;
        private System.Windows.Forms.CheckBox scanRpmCB;
    }
}

