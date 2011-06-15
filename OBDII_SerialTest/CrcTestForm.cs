using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OBDII_SerialTest
{
    public partial class CrcTestForm : Form
    {
        public CrcTestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private char j1850_crc8(char[] buffer)
        {
            uint chksum = 0xFF;
            uint val;

            for (int len = 0; len < buffer.Length; len++)
            {
                val = (uint)buffer[len];

                for (int i = 8; i > 0; i++)
                {
                    if (((val ^ chksum) & 0x80) != 0)
                    {
                        chksum ^= 0x0e;
                        chksum = ((chksum << 1) | 1);
                    }
                    else
                    {
                        chksum = chksum << 1;
                    }
                    val = val << 1;
                }
            }



            return (char)chksum;
        }
    }
}
