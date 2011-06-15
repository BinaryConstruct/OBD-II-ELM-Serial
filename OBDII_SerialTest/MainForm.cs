using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Text.RegularExpressions;


namespace OBDII_SerialTest
{
    public partial class MainForm : Form
    {
        public string lastCommand = "";
        public bool elmReady = true;
        public List<string> commandBuffer = new List<string>();

        public MainForm()
        {
            InitializeComponent();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        #region - UI -

        private void commResetBTN_Click(object sender, EventArgs e)
        {
            commOpen();
        }

        private void baud348RB_CheckedChanged(object sender, EventArgs e)
        {
            if (baud348RB.Checked)
                serialELM.BaudRate = 38400;
            else
                serialELM.BaudRate = 9600;
        }

        private void portNameTB_TextChanged(object sender, EventArgs e)
        {
            serialELM.PortName = portNameTB.Text;
        }

        private void commCloseBTN_Click(object sender, EventArgs e)
        {
            commClose();
        }

        /// <summary>
        /// Set the status label and color based on connection.
        /// </summary>
        /// <param name="statusCode">0: listening, 1: opening, 2: not connected</param>
        private void setStatusLBL(int statusCode)
        {
            switch (statusCode)
            {
                case 0:
                    statusLBL.Text = "Listening";
                    statusLBL.ForeColor = Color.Lime;
                    break;
                case 1:
                    statusLBL.Text = "Opening";
                    statusLBL.ForeColor = Color.Yellow;
                    break;
                case 2:
                    statusLBL.Text = "Not Connected";
                    statusLBL.ForeColor = Color.Red;
                    break;
                default:
                    statusLBL.Text = "Not Connected";
                    statusLBL.ForeColor = Color.Red;
                    break;
            }
        }

        private void commSendBTN_Click(object sender, EventArgs e)
        {
            elmCommand(commandTB.Text);
        }

        private void checkSerialLine_Tick(object sender, EventArgs e)
        {
            if (rxtxTB.Text.Trim() == "Attempting to connect to ELM...")
            {
                addRxTxMessage("ERROR: Connection Timeout", Color.Red);
                commClose();
            }

            if (serialELM.IsOpen)
                setStatusLBL(0);
            else
                setStatusLBL(2);

        }

        private void rxtxTB_TextChanged(object sender, EventArgs e)
        {
            rxtxTB.SelectionStart = rxtxTB.Text.Length;
            rxtxTB.ScrollToCaret();
        }

        private void echoCB_CheckedChanged(object sender, EventArgs e)
        {
            if (serialELM.IsOpen)
            {
                if (echoCB.Checked)
                    elmCommand("AT E1");
                else
                    elmCommand("AT E0");
            }
            else
            {
                echoCB.Checked = true;
            }
        }

        private void outTB_MouseEnter(object sender, EventArgs e)
        {
            TextBox myTB = sender as TextBox;
            myTB.BackColor = Color.FromArgb(32, 0, 0);
            sender = myTB;
        }

        private void outTB_MouseLeave(object sender, EventArgs e)
        {
            outVoltageTB.BackColor = Color.Black;
        }

        private void commandTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                elmCommand(commandTB.Text);
            }
        }

        private void headersCB_CheckedChanged(object sender, EventArgs e)
        {
            if (headersCB.Checked)
                elmCommand("AT H1");
            else
                elmCommand("AT H0");
        }

        private void monitorBTN_Click(object sender, EventArgs e)
        {
            elmCommand("AT MA");
        }

        private void warmstartBTN_Click(object sender, EventArgs e)
        {
            serialELM.Write("AT WS");
        }

        private void savelogBTN_Click(object sender, EventArgs e)
        {
            saveLog();
        }

        private void checkPid1BTN_Click(object sender, EventArgs e)
        {
            elmCommand("01 00");
            //elmCommand("01 20");
            //elmCommand("01 40");
        }

        private void vistaButton5_Click(object sender, EventArgs e)
        {
            checkPIDs("ED6CF43F", 0x20);
        }

        private void vistaButton7_Click(object sender, EventArgs e)
        {
            for (int pid = 4; pid < 0x20; pid++)
            {
                elmCommand("01 " + pid.ToString("X2"));
            }
        }

        private void testParseBTN_Click(object sender, EventArgs e)
        {
            responseParser(commandTB.Text);
        }


        private void abortBTN_Click(object sender, EventArgs e)
        {
            serialELM.Write("\r");
        }

 

        private void scanRpmCB_CheckedChanged(object sender, EventArgs e)
        {
            elmTimer.Enabled = scanRpmCB.Checked;
        }

        #endregion

        #region - Set Up Connection -

        private void commClose()
        {
            if (serialELM.IsOpen)
            {
                checkSerialLine.Enabled = false;
                serialELM.Close();
                setStatusLBL(2);
                addRxTxMessage("------------------\r\nConnection Closed.", Color.Yellow);
            }
            else
                addRxTxMessage("ERROR: Port not open.", Color.Silver);
        }

        private void commOpen()
        {
           
            rxtxTB.Text = "";
            addRxTxMessage("Attempting to connect to ELM...", Color.Lime);
            //rxtxTB.Text += "Port: " + serialELM.PortName + " Baud: " + serialELM.BaudRate;

            serialELM.Close();
            setStatusLBL(1);
            
            try
            {
                serialELM.Open();
                elmCommand("ATZ");
                checkSerialLine.Enabled = true;
                checkSerialLine.Stop();
                checkSerialLine.Start();
            }
            catch (Exception err)
            {
                addRxTxMessage("ERROR: " + err.Message + "", Color.Red);
                setStatusLBL(2);
            }
        }

        #endregion

        #region - Message Handling -

        private void elmTimer_Tick(object sender, EventArgs e)
        {
            if ((commandBuffer.Count > 0 || scanRpmCB.Checked) && elmReady)
            {
                string command = "010C";
                if (!scanRpmCB.Checked)
                {
                    command = commandBuffer[0];
                    commandBuffer.RemoveAt(0);
                }
                try
                {
                    if (serialELM.IsOpen)
                    {
                        elmReady = false;
                        serialELM.Write(command.Trim() + Environment.NewLine);
                        if (command.Trim() != "")
                            lastCommand = command.Trim();
                    }
                    else
                        addRxTxMessage("ERROR: Connection not open!", Color.Red);
                }
                catch (Exception err)
                {
                    addRxTxMessage(err.Message + "", Color.Red);
                }
            }

            if (commandBuffer.Count == 0 && !scanRpmCB.Checked)
                elmTimer.Enabled = false;

        }

        public void elmCommand(string command)
        {
            commandBuffer.Add(command);
            elmTimer.Enabled = true;
        }

        public void setRPMGauge(float rpmVal)
        {
            if (rpmTB.InvokeRequired)
            {
                rpmTB.Invoke(new EventHandler(
                    delegate
                    {
                        rpmTB.Text = rpmVal.ToString("0") + " RPM";
                    }));
            }
            else
            {
                rpmTB.Text = rpmVal.ToString("0") + " RPM";
            }
        }

        public void addRxTxMessage(string message)
        {
            addRxTxMessage(message, Color.Lime);
        }
        public void addRxTxMessage(string message, Color useColor)
        {
            if (rxtxTB.InvokeRequired)
            {
                rxtxTB.Invoke(new EventHandler(
                    delegate
                    {
                        rxtxTB.SelectionStart = rxtxTB.Text.ToCharArray().Length;
                        rxtxTB.SelectionColor = useColor;
                        rxtxTB.SelectedText += message.Trim() + "\r\n";
                    }));
            }
            else
            {
                rxtxTB.SelectionStart = rxtxTB.Text.ToCharArray().Length;
                rxtxTB.SelectionColor = useColor;
                rxtxTB.SelectedText += message.Trim() + "\r\n";
            }
        }

        private void serialELM_DataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialELM.IsOpen)
            {
                StringBuilder response = new StringBuilder();
                string message;
                while ((message = ((char)serialELM.ReadByte()).ToString()) != null && message != "" )
                {
                    response.Append(message);
                    if (message == ">")
                    {
                        elmReady = true;
                        addRxTxMessage(message + "");
                        response = new StringBuilder();
                    }

                    if (message == "\r")
                    {
                        addRxTxMessage(response + "");
                        responseParser(response.ToString());
                        response = new StringBuilder();
                    }
                }
            }
        }

        private void serialELM_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            rxtxTB.Text = e.ToString();
        }

        private void responseParser(string response)
        {
            string responseTrim = Regex.Replace(response.TrimStart(new char[] { '?', '>', ' ' }).TrimEnd(new char[] { '?', '>', ' ' }).Trim(), " ", "");
                
            int resint = 0;
            string checkResponse = "";
            if (responseTrim.Length > 4)
            {
                checkResponse = responseTrim.Substring(0, 4);
                if (responseTrim.Substring(0, 2) == "43")
                    checkResponse = responseTrim.Substring(0, 2);

                if (responseTrim.Substring(0, 2) == "41")
                    resint = int.Parse(responseTrim.Substring(4, responseTrim.Length - 4), System.Globalization.NumberStyles.HexNumber);

                if (responseTrim.Substring(0, 2) == "91")
                    checkResponse = responseTrim.Substring(0, 6);
            }

            OBDSpecialPID obdPids = new OBDSpecialPID();
            switch (checkResponse)
            {
                case "43":
                    string responseTrimSUb = responseTrim.Substring(2, 12);
                    List<string> tcodes = obdPids.TroubleCodes(responseTrimSUb);
                    foreach (string tCode in tcodes)
                    {
                        addRxTxMessage(tCode + "");
                    } 
                    break;
                case "Batt":
                    if (outVoltageTB.InvokeRequired)
                    {
                        outVoltageTB.Invoke(new EventHandler(
                            delegate
                            {
                                outVoltageTB.Text = responseTrim.TrimStart(new char[] { 'A', 'T', 'R', 'V', ' ' });
                            }));
                    }
                    else
                    {
                        outVoltageTB.Text = responseTrim.TrimStart(new char[] { 'A', 'T', 'R', 'V', ' ' });
                    }
                    
                    break;
                case "4100":
                    checkPIDs(responseTrim.Substring(4, responseTrim.Length - 4), 0);
                    break;
                case "4120":
                    checkPIDs(responseTrim.Substring(4, responseTrim.Length - 4), 0x20);
                    break;
                case "4140":
                    checkPIDs(responseTrim.Substring(4, responseTrim.Length - 4), 0x40);
                    break;
                case "910000":
                    checkPIDs(responseTrim.Substring(6, responseTrim.Length - 6), 0);
                    break;
                case "4101":
                    OBDSpecialPID.EngineStatus stat = obdPids.pid0101(responseTrim.Substring(4, responseTrim.Length - 4));
                    addRxTxMessage("MIL Active: " + stat.MILActive.ToString(), Color.PowderBlue);
                    addRxTxMessage("Trouble Code Count: " + stat.TroubleCodeCount.ToString() + "", Color.PowderBlue);

                    addRxTxMessage("AC Refrigerant\r\nAvailable: " + stat.ACRefrigerant.Available + " Passed: " + stat.ACRefrigerant.Passed, Color.PowderBlue);
                    addRxTxMessage("Catalyst\r\nAvailable: " + stat.Catalyst.Available + " Passed: " + stat.Catalyst.Passed, Color.PowderBlue);
                    addRxTxMessage("CatalystHeated\r\nAvailable: " + stat.CatalystHeated.Available + " Passed: " + stat.CatalystHeated.Passed, Color.PowderBlue);
                    addRxTxMessage("Components\r\nAvailable: " + stat.Components.Available + " Passed: " + stat.Components.Passed, Color.PowderBlue);
                    addRxTxMessage("EGRSystem\r\nAvailable: " + stat.EGRSystem.Available + " Passed: " + stat.EGRSystem.Passed, Color.PowderBlue);
                    addRxTxMessage("EvapSystem\r\nAvailable: " + stat.EvapSystem.Available + " Passed: " + stat.EvapSystem.Passed, Color.PowderBlue);
                    addRxTxMessage("FuelSystem\r\nAvailable: " + stat.FuelSystem.Available + " Passed: " + stat.FuelSystem.Passed, Color.PowderBlue);
                    addRxTxMessage("Misfire\r\nAvailable: " + stat.Misfire.Available + " Passed: " + stat.Misfire.Passed, Color.PowderBlue);
                    addRxTxMessage("O2Sensor\r\nAvailable: " + stat.O2Sensor.Available + " Passed: " + stat.O2Sensor.Passed, Color.PowderBlue);
                    addRxTxMessage("O2SensorHeater\r\nAvailable: " + stat.O2SensorHeater.Available + " Passed: " + stat.O2SensorHeater.Passed, Color.PowderBlue);
                    addRxTxMessage("Reserved\r\nAvailable: " + stat.Reserved.Available + " Passed: " + stat.Reserved.Passed, Color.PowderBlue);
                    addRxTxMessage("SecondaryAirSystem: " + stat.SecondaryAirSystem.Available + " Passed: " + stat.SecondaryAirSystem.Passed, Color.PowderBlue);
                    
                    //if ((resint & uint.Parse("", System.Globalization.NumberStyles.HexNumber);
                    break;
                case "4103":
                    addRxTxMessage(obdPids.pid0103(responseTrim.Substring(4, 2)));
                    break;
                case "4104":
                    int calcLoad = resint * 100 / 255;
                    addRxTxMessage("" + calcLoad.ToString() + "% Engine Load");
                    break;
                case "4105":
                    int tempC = resint - 40;
                    int tempF = (9 * tempC / 5) + 32;
                    addRxTxMessage("" + tempC.ToString() + " C  coolant Temp");
                    addRxTxMessage("" + tempF.ToString() + " F  coolant Temp");
                    break;
                case "4106":
                    int trim = (resint - 128) * 100 / 128;
                    addRxTxMessage("" + trim.ToString() + "% STFT Bank 1");
                    break;
                case "4107":
                    trim = (resint - 128) * 100 / 128;
                    addRxTxMessage("" + trim.ToString() + "% LTFT Bank 1");
                    break;
                case "4108":
                    trim = (resint - 128) * 100 / 128;
                    addRxTxMessage("" + trim.ToString() + "% STFT Bank 2");
                    break;
                case "4109":
                    trim = (resint - 128) * 100 / 128;
                    addRxTxMessage("" + trim.ToString() + "% LTFT Bank 2");
                    break;
                case "410A":
                    int val = (resint - 128) * 100 / 128;
                    addRxTxMessage("" + val.ToString() + " kPa Fuel Pressure");
                    break;
                case "410B":
                    addRxTxMessage("" + resint.ToString() + " kPa MAP");
                    break;
                case "410C":
                    val = (int)(resint / 4);
                    addRxTxMessage("" + val.ToString() + " RPM");
                    setRPMGauge((float)(resint / 4));
                    break;
                case "410D":
                    addRxTxMessage("" + resint.ToString() + " km/H ");
                    break;
                case "410E":
                    val = (resint / 2) - 64;
                    addRxTxMessage("" + val.ToString() + " Degrees Advance");
                    break;
                case "410F":
                    tempC = resint - 40;
                    tempF = (9 * tempC / 5) + 32;
                    addRxTxMessage("" + tempC.ToString() + " C  Intake Temp");
                    addRxTxMessage("" + tempF.ToString() + " F  Intake Temp");
                    break;
                case "4110":
                    val = (resint / 100);
                    addRxTxMessage("" + val.ToString() + " g/s MAF");
                    break;
                case "4111":
                    val = resint * 100 / 255;
                    addRxTxMessage("" + val.ToString() + "% Throttle");
                    break;
                case "4112":
                    addRxTxMessage(obdPids.pid0112(responseTrim.Substring(4, responseTrim.Length - 4)));
                    break;
                case "411C":
                    addRxTxMessage(obdPids.pid011C(responseTrim.Substring(4, responseTrim.Length - 4)));
                    break;
                default:
                    //addRxTxMessage(response, Color.Lime);
                    break;
            }

        }

        #endregion

        #region - Scan PID Text Boxes -

        private void outVoltageTB_Click(object sender, EventArgs e)
        {
            addRxTxMessage("READING: Batt Voltage", Color.FromArgb(128, 128, 255));
            elmCommand("ATRV");
        }

        #endregion

        #region - CRC Check -


        private byte crc8(byte[] buffer)
        {
            return crc8(buffer, false);
        }
        private byte crc8(byte[] buffer, bool iso)
        {
            byte crc_reg = (byte)0xFF;
            byte checksum = (byte)0;
            byte val;

            for (int len = 0; len < buffer.Length; len++)
            {
                val = buffer[len];
                checksum += val;

                for (int i = 8; i > 0; i--)
                {
                    if (((val ^ crc_reg) & 0x80) != (byte)0)
                    {
                        crc_reg ^= 0x0e;
                        crc_reg = (byte)((crc_reg << 1) | 1);
                    }
                    else
                        crc_reg = (byte)(crc_reg << 1);

                    val = (byte)(val << 1);
                }

            }
            if (iso)
                return checksum;
            else
                return (byte)~crc_reg;
        }



        private void crcBTN_Click(object sender, EventArgs e)
        {
            string crcstr = Regex.Replace(commandTB.Text, " ", "");
            byte[] crcbuff = new byte[crcstr.Length / 2];

            for (int position = 0; position < crcstr.Length / 2; position++)
            {
                string bytebuf = crcstr.Substring(position * 2, 2);
                crcbuff[position] = byte.Parse(bytebuf, System.Globalization.NumberStyles.HexNumber);
            }

            rxtxTB.Text += "CRC8:" + crc8(crcbuff).ToString("X2");
        }

        #endregion

        #region - Conversions - 
        public string byte2bin(string bytestr)
        {
            string bin = "0000";
            switch (bytestr)
            {
                case "1":
                    bin = "0001";
                    break;
                case "2":
                    bin = "0010";
                    break;
                case "3":
                    bin = "0011";
                    break;
                case "4":
                    bin = "0100";
                    break;
                case "5":
                    bin = "0101";
                    break;
                case "6":
                    bin = "0110";
                    break;
                case "7":
                    bin = "0111";
                    break;
                case "8":
                    bin = "1000";
                    break;
                case "9":
                    bin = "1001";
                    break;
                case "A":
                    bin = "1010";
                    break;
                case "B":
                    bin = "1011";
                    break;
                case "C":
                    bin = "1100";
                    break;
                case "D":
                    bin = "1101";
                    break;
                case "E":
                    bin = "1110";
                    break;
                case "F":
                    bin = "1111";
                    break;
                default:
                    bin = "0000";
                    break;
            }
            return bin;
        }
        #endregion

        private void saveLog()
		{

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {


                string logFile = saveFileDialog1.FileName;
                try
                {
                    FileStream fs_exists = new FileStream(logFile, FileMode.OpenOrCreate, FileAccess.Write);
                    fs_exists.Close();

                    FileStream fs = new FileStream(logFile, FileMode.Append, FileAccess.Write);
                    StreamWriter s = new StreamWriter(fs);

                    s.Write(rxtxTB.Text);

                    s.Close();
                    fs.Close();
                }

                catch (Exception err)
                {
                    throw new System.Exception(err.ToString());
                }
            }
        }

        private void checkPIDs(string response, int offset)
        {
            response = Regex.Replace(response, " ", "");
            if (response.Length <= 4 || response == "NODATA")
                return;
            
            uint validPIDS = uint.Parse(response, System.Globalization.NumberStyles.HexNumber);

            uint mask = 0x80000000;
            for (int pid = 1; pid <= 0x20; pid++)
            {
                addRxTxMessage("PID " + (pid + offset).ToString("X2") + ": ", Color.White);
                if ((validPIDS & mask) != 0)
                    addRxTxMessage("Enabled", Color.Lime);
                else
                    addRxTxMessage("Disabled", Color.Red);
                    
                mask = mask >> 1;
            }
        }





    }

    #region - Classes -
    public class Crc16
    {
        const ushort polynomial = 0xA001;
        ushort[] table = new ushort[256];

        public ushort ComputeChecksum(byte[] bytes)
        {
            ushort crc = 0;
            for (int i = 0; i < bytes.Length; ++i)
            {
                byte index = (byte)(crc ^ bytes[i]);
                crc = (ushort)((crc >> 8) ^ table[index]);
            }
            return crc;
        }

        public byte[] ComputeChecksumBytes(byte[] bytes)
        {
            ushort crc = ComputeChecksum(bytes);
            return new byte[] { (byte)(crc >> 8), (byte)(crc & 0x00ff) };
        }

        public Crc16()
        {
            ushort value;
            ushort temp;
            for (ushort i = 0; i < table.Length; ++i)
            {
                value = 0;
                temp = i;
                for (byte j = 0; j < 8; ++j)
                {
                    if (((value ^ temp) & 0x0001) != 0)
                    {
                        value = (ushort)((value >> 1) ^ polynomial);
                    }
                    else
                    {
                        value >>= 1;
                    }
                    temp >>= 1;
                }
                table[i] = value;
            }
        }

        
    }



    public class OBDSpecialPID
    {

        public struct EngineTest
        {
            public bool Available;
            public bool Passed;
        }

        public struct EngineStatus
        {
            public bool MILActive;
            public int TroubleCodeCount;
            public EngineTest Misfire;
            public EngineTest FuelSystem;
            public EngineTest Components;
            public EngineTest Reserved;
            public EngineTest Catalyst;
            public EngineTest CatalystHeated;
            public EngineTest EvapSystem;
            public EngineTest SecondaryAirSystem;
            public EngineTest ACRefrigerant;
            public EngineTest O2Sensor;
            public EngineTest O2SensorHeater;
            public EngineTest EGRSystem;
        }

        /// <summary>
        /// Engine Status and test summary
        /// </summary>
        /// <param name="response">4 Bytes</param>
        /// <returns>EngineStatus</returns>
        public EngineStatus pid0101(string response)
        {
            EngineStatus vehicleStatus = new EngineStatus();

            byte[] troubleBytes = new byte[4];
            for (int byteNum = 0; byteNum < response.Length / 2; byteNum++)
            {
                troubleBytes[byteNum] = byte.Parse(response.Substring(byteNum, 2), System.Globalization.NumberStyles.HexNumber);
            }

            // Trouble Codes
            if (troubleBytes[0] > 0x80)
            {
                vehicleStatus.MILActive = true;
                troubleBytes[0] -= 0x80;
            }
            vehicleStatus.TroubleCodeCount = (int)(troubleBytes[0]);

            // System Tests
            vehicleStatus.Misfire.Available = ((troubleBytes[1] & 0x01) > 0);
            vehicleStatus.Misfire.Passed = ((troubleBytes[1] & 0x10) > 0);

            vehicleStatus.FuelSystem.Available = ((troubleBytes[1] & 0x02) > 0);
            vehicleStatus.FuelSystem.Passed = ((troubleBytes[1] & 0x20) > 0);

            vehicleStatus.Components.Available = ((troubleBytes[1] & 0x04) > 0);
            vehicleStatus.Components.Passed = ((troubleBytes[1] & 0x40) > 0);

            vehicleStatus.Reserved.Available = ((troubleBytes[1] & 0x08) > 0);
            vehicleStatus.Reserved.Passed = ((troubleBytes[1] & 0x80) > 0);

            vehicleStatus.Catalyst.Available = ((troubleBytes[2] & 0x01) > 0);
            vehicleStatus.Catalyst.Passed = ((troubleBytes[3] & 0x01) > 0);

            vehicleStatus.CatalystHeated.Available = ((troubleBytes[2] & 0x02) > 0);
            vehicleStatus.CatalystHeated.Passed = ((troubleBytes[3] & 0x02) > 0);

            vehicleStatus.EvapSystem.Available = ((troubleBytes[2] & 0x04) > 0);
            vehicleStatus.EvapSystem.Passed = ((troubleBytes[3] & 0x04) > 0);

            vehicleStatus.SecondaryAirSystem.Available = ((troubleBytes[2] & 0x08) > 0);
            vehicleStatus.SecondaryAirSystem.Passed = ((troubleBytes[3] & 0x08) > 0);

            vehicleStatus.ACRefrigerant.Available = ((troubleBytes[2] & 0x10) > 0);
            vehicleStatus.ACRefrigerant.Passed = ((troubleBytes[3] & 0x10) > 0);

            vehicleStatus.O2Sensor.Available = ((troubleBytes[2] & 0x20) > 0);
            vehicleStatus.O2Sensor.Passed = ((troubleBytes[3] & 0x20) > 0);

            vehicleStatus.O2SensorHeater.Available = ((troubleBytes[2] & 0x40) > 0);
            vehicleStatus.O2SensorHeater.Passed = ((troubleBytes[3] & 0x40) > 0);

            vehicleStatus.EGRSystem.Available = ((troubleBytes[2] & 0x80) > 0);
            vehicleStatus.EGRSystem.Passed = ((troubleBytes[3] & 0x80) > 0);

            return vehicleStatus;
        }

        /// <summary>
        /// Fuel Mode
        /// </summary>
        /// <param name="response">Single Byte</param>
        /// <returns>Status String</returns>
        public string pid0103(string response)
        {
            byte responseBytes = byte.Parse(response, System.Globalization.NumberStyles.HexNumber);
            string fuelMode = "Open Loop - Warmup";
            switch (responseBytes)
            {
                case (byte)0x01:
                    fuelMode = "Open Loop - Warmup";
                    break;
                case (byte)0x02:
                    fuelMode = "Closed Loop";
                    break;
                case (byte)0x04:
                    fuelMode = "Open Loop";
                    break;
                case (byte)0x08:
                    fuelMode = "Open Loop - System Failure";
                    break;
                case (byte)0x10:
                    fuelMode = "Closed Loop - Fault";
                    break;
            }

            return fuelMode;
        }

        /// <summary>
        /// Secondary AIR Status
        /// </summary>
        /// <param name="response">Single Byte</param>
        /// <returns>Status String</returns>
        public string pid0112(string response)
        {
            byte responseBytes = byte.Parse(response, System.Globalization.NumberStyles.HexNumber);
            string airStatus = "NO DATA";
            switch (responseBytes)
            {
                case (byte)0x01:
                    airStatus = "Upstream of catalytic converter";
                    break;
                case (byte)0x02:
                    airStatus = "Downstream of catalytic converter";
                    break;
                case (byte)0x04:
                    airStatus = "Outside atmosphere or off";
                    break;
            }
            return airStatus;
        }

        /// <summary>
        /// OBD Standard the ECU complies with.
        /// </summary>
        /// <param name="response">Single byte</param>
        /// <returns>Satus String</returns>
        public string pid011C(string response)
        {
            byte responseBytes = byte.Parse(response, System.Globalization.NumberStyles.HexNumber);
            string status = "NO DATA";
            switch (responseBytes)
            {
                case (byte)0x01:
                    status = "OBD-II as defined by the CARB";
                    break;
                case (byte)0x02:
                    status = "OBD as defined by the EPA";
                    break;
                case (byte)0x03:
                    status = "OBD and OBD-II";
                    break;
                case (byte)0x04:
                    status = "OBD-I";
                    break;
                case (byte)0x05:
                    status = "No standard OBD";
                    break;
                case (byte)0x06:
                    status = "EOBD";
                    break;
            }

            return status;
        }

        public List<string> TroubleCodes(string response)
        {
            List<string> troubleCodeList = new List<string>();
            for (int byteNum = 0; byteNum < response.Length / 4; byteNum++)
            {
                string code = "";
                string troubleCode = response.Substring(byteNum * 4, 4);
                byte moduleCode = byte.Parse(troubleCode.Substring(1, 1), System.Globalization.NumberStyles.HexNumber);

                if (moduleCode < 0x4)
                    code += "P";
                else if ((moduleCode & 0x4) > 0)
                    code += "C";
                else if ((moduleCode & 0x8) > 0)
                    code += "B";
                else if ((moduleCode & 0xC) > 0)
                    code += "U";

                if (moduleCode == 0x0)
                    code += "0";
                else if ((moduleCode & 0x1) > 0)
                    code += "1";
                else if ((moduleCode & 0x2) > 0)
                    code += "2";
                else if ((moduleCode & 0x3) > 0)
                    code += "3";

                code += troubleCode.Substring(1, 3);
                troubleCodeList.Add(code);
            }

            return troubleCodeList;
        }
        
    }


    #endregion
}
