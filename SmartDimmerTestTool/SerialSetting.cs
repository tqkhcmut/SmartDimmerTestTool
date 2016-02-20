using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SmartDimmerTestTool
{
    public partial class SerialSetting : Form
    {
        public SerialSetting()
        {
            InitializeComponent();
        }
        public struct SerialSetting_t
        {
            public string COMPort;
            public string Baudrate;
            public string DataSize;
            public StopBits StopBit;
            public Parity parity;
        };

        public SerialSetting_t serialSetting;

        private void SerialSetting_Load(object sender, EventArgs e)
        {

        }

        private void SerialConnect_bt_Click(object sender, EventArgs e)
        {

        }
    }
}
