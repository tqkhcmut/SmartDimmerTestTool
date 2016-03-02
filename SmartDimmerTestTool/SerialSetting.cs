using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;

namespace SmartDimmerTestTool
{
    public partial class SerialSetting : Form
    {
        public SerialSetting(SerialSetting_t setting)
        {
            this.serialSetting = setting;
            InitializeComponent();
        }

        public SerialSetting_t serialSetting = new SerialSetting_t();

        private void SerialSetting_Load(object sender, EventArgs e)
        {
            foreach (string s in SerialPort.GetPortNames())
            {
                Ports_cb.Items.Add(s);
            }
            Ports_cb.SelectedIndex = 0;
            Baudrate_cb.Text = serialSetting.Baudrate.ToString();
            DataBits_cb.Text = serialSetting.DataBits.ToString();
            switch (serialSetting.StopBit)
            {
                case StopBits.None:
                    StopBit_cb.SelectedIndex = 0;
                    break;
                case StopBits.One:
                    StopBit_cb.SelectedIndex = 1;
                    break;
                case StopBits.OnePointFive:
                    StopBit_cb.SelectedIndex = 2;
                    break;
                case StopBits.Two:
                    StopBit_cb.SelectedIndex = 3;
                    break;
                default:
                    StopBit_cb.SelectedIndex = 1;
                    break;
            }
            switch (serialSetting.Parity)
            {
                case Parity.Even:
                    Parity_cb.SelectedIndex = 0;
                    break;
                case Parity.Mark:
                    Parity_cb.SelectedIndex = 1;
                    break;
                case Parity.None:
                    Parity_cb.SelectedIndex = 2;
                    break;
                case Parity.Odd:
                    Parity_cb.SelectedIndex = 3;
                    break;
                case Parity.Space:
                    Parity_cb.SelectedIndex = 4;
                    break;
                default:
                    Parity_cb.SelectedIndex = 2;
                    break;
            }
        }

        private void SerialConnect_bt_Click(object sender, EventArgs e)
        {
            try
            {
                serialSetting.PortName = Ports_cb.Text;
                serialSetting.DataBits = int.Parse(DataBits_cb.Text);
                serialSetting.Baudrate = int.Parse(Baudrate_cb.Text);
                switch (StopBit_cb.Text)
                {
                    case "None":
                        serialSetting.StopBit = StopBits.None;
                        break;
                    case "One":
                        serialSetting.StopBit = StopBits.One;
                        break;
                    case "One Point Five":
                        serialSetting.StopBit = StopBits.OnePointFive;
                        break;
                    case "Two":
                        serialSetting.StopBit = StopBits.Two;
                        break;
                    default:
                        serialSetting.StopBit = StopBits.One;
                        break;
                }
                switch (Parity_cb.Text)
                {
                    case "Even":
                        serialSetting.Parity = Parity.Even;
                        break;
                    case "Mark":
                        serialSetting.Parity = Parity.Mark;
                        break;
                    case "None":
                        serialSetting.Parity = Parity.None;
                        break;
                    case "Odd":
                        serialSetting.Parity = Parity.Odd;
                        break;
                    case "Space":
                        serialSetting.Parity = Parity.Space;
                        break;
                    default:
                        serialSetting.Parity = Parity.None;
                        break;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                this.Close();
            }
            this.Close();
        }
    }
}
