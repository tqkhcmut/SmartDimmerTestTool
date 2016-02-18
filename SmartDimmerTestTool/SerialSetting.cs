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

        public SerialSetting(ref SerialPort serial)
        {

        }

        private void SerialSetting_Load(object sender, EventArgs e)
        {

        }
    }
}
