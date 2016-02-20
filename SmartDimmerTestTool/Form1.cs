using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace SmartDimmerTestTool
{
    public partial class SmartDimmerTT : Form
    {
        public SmartDimmerTT()
        {
            InitializeComponent();
        }

        private void formClosing(object sender, FormClosingEventArgs arg)
        {
            if (COMSerialPort.IsOpen)
                COMSerialPort.Close();
            SerialListener.CancelAsync();
        }

        private Mutex serialAccess = new Mutex();

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SerialSetting sSetting = new SerialSetting();
            DialogResult res = sSetting.ShowDialog();
            if (res == DialogResult.OK)
            {
                
            }
            else
            {

            }
        }

        private string Bs2str(byte [] data)
        {
            string res = "";
            foreach (byte b in data)
                res += b.ToString("X2") + " ";
            return res;
        }

        private void SerialListener_DoWork(object sender, DoWorkEventArgs e)
        {
            appendMsg("Serial Listener is running.");
            while (true)
            {
                try
                {
                    if (serialAccess.WaitOne())
                    {
                        if (COMSerialPort.IsOpen)
                        {
                            if (COMSerialPort.BytesToRead > 0)
                            {
                                byte[] buffer = new byte[COMSerialPort.BytesToRead];
                                COMSerialPort.Read(buffer, 0, COMSerialPort.BytesToRead);
                                appendMsg(Bs2str(buffer));

                                if (buffer[0] == 0x11 && buffer[1] == 0x03 && buffer[2] == 0x02)
                                {
                                    byte[] tmp = {buffer[3], buffer[4], buffer[5], buffer[6]};
                                    appendFoundID(Bs2str(tmp));
                                }
                            }
                        }

                        serialAccess.ReleaseMutex();
                    }
                }
                catch (Exception err)
                {
                    serialAccess.ReleaseMutex();
                    Debug.WriteLine(err.Message);
                }
                Thread.Sleep(10);
            }
        }

        private void SerialListener_finished(object sender, RunWorkerCompletedEventArgs args)
        {
            if (COMSerialPort.IsOpen)
                COMSerialPort.Close();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connectToolStripMenuItem.Text == "Connect")
            {
                if (serialAccess.WaitOne())
                {
                    try
                    {
                        if (!COMSerialPort.IsOpen)
                        {
                            COMSerialPort.Open();
                        }
                        appendMsg(COMSerialPort.PortName + " is opened.");
                    }
                    catch(Exception err)
                    {
                        appendMsg(err.Message);
                        serialAccess.ReleaseMutex();
                    }
                    serialAccess.ReleaseMutex();
                }
                connectToolStripMenuItem.Text = "Disconnect";
            }
            else
            {
                if (serialAccess.WaitOne())
                {
                    try
                    {
                        if (COMSerialPort.IsOpen)
                        {
                            COMSerialPort.Close();
                        }
                    }
                    catch (Exception err)
                    {
                        appendMsg(err.Message);
                        serialAccess.ReleaseMutex();
                    }
                    serialAccess.ReleaseMutex();
                }
                appendMsg(COMSerialPort.PortName + " is closed.");
                connectToolStripMenuItem.Text = "Connect";
            }
        }

        private Color rt_color = Color.Green;
        private Mutex msg_access = new Mutex();
        private void appendMsg(string msg)
        {
            if (msg_access.WaitOne())
            {
                if (message_rtext.InvokeRequired)
                {
                    msg_access.ReleaseMutex();
                    this.Invoke(new Action<string>(appendMsg), new object[] { msg });
                    return;
                }
                else
                {
                    message_rtext.SelectionColor = rt_color;
                    message_rtext.AppendText(msg + Environment.NewLine);
                    message_rtext.SelectionStart = message_rtext.Text.Length;
                    message_rtext.ScrollToCaret();
                    if (rt_color == Color.Green)
                    {
                        rt_color = Color.Blue;
                    }
                    else
                    {
                        rt_color = Color.Green;
                    }
                }
                msg_access.ReleaseMutex();
            }
        }

        private Color FoundID_rt_color = Color.Green;
        private Mutex FoundID_rtext_access = new Mutex();
        private void appendFoundID(string msg)
        {
            if (FoundID_rtext_access.WaitOne())
            {
                if (FoundID_rtext.InvokeRequired)
                {
                    FoundID_rtext_access.ReleaseMutex();
                    this.Invoke(new Action<string>(appendFoundID), new object[] { msg });
                    return;
                }
                else
                {
                    FoundID_rtext.SelectionColor = FoundID_rt_color;
                    FoundID_rtext.AppendText(msg + Environment.NewLine);
                    FoundID_rtext.SelectionStart = FoundID_rtext.Text.Length;
                    FoundID_rtext.ScrollToCaret();
                    if (FoundID_rt_color == Color.Green)
                    {
                        FoundID_rt_color = Color.Blue;
                    }
                    else
                    {
                        FoundID_rt_color = Color.Green;
                    }
                }
                FoundID_rtext_access.ReleaseMutex();
            }
        }

        private void SmartDimmerTT_Load(object sender, EventArgs e)
        {
            SerialListener.WorkerSupportsCancellation = true;
            appendMsg("Start Serial Listenner.");
            SerialListener.RunWorkerAsync();
            TargetID_cb.SelectedIndex = 0;
        }

        private void get_temp_bt_Click(object sender, EventArgs e)
        {
            byte[] data = { 0x01, 0x02, 0x02, 0xff, 0xff, 0xff, 0xff, 0x03, 0xfe };
            string[] ss = TargetID_cb.Text.Split(' ');
            try
            {
                if (data.Length < 4)
                    throw new Exception("Not enough ID length.");
                data[3] = Convert.ToByte(ss[0], 16);
                data[4] = Convert.ToByte(ss[1], 16);
                data[5] = Convert.ToByte(ss[2], 16);
                data[6] = Convert.ToByte(ss[3], 16);
            }
            catch (Exception err)
            {
                appendMsg(err.Message);
                foreach (string s in ss)
                    appendMsg("*" + s);
            }
            if (serialAccess.WaitOne())
            {
                if (COMSerialPort.IsOpen)
                {
                    appendMsg("Get Temperature: " + Bs2str(data));
                    COMSerialPort.Write(data, 0, data.Length);
                }
                else
                {
                    appendMsg(COMSerialPort.PortName + " is closed.");
                }
                serialAccess.ReleaseMutex();
            }
        }

        private void GetPCBTime_bt_Click(object sender, EventArgs e)
        {
            byte[] data = { 0x06, 0x02, 0x02, 0xff, 0xff, 0xff, 0xff, 0x03, 0xfe };
            string[] ss = TargetID_cb.Text.Split(' ');
            try
            {
                if (data.Length < 4)
                    throw new Exception("Not enough ID length.");
                data[3] = Convert.ToByte(ss[0], 16);
                data[4] = Convert.ToByte(ss[1], 16);
                data[5] = Convert.ToByte(ss[2], 16);
                data[6] = Convert.ToByte(ss[3], 16);
            }
            catch (Exception err)
            {
                appendMsg(err.Message);
                foreach (string s in ss)
                    appendMsg("*" + s);
            }
            if (serialAccess.WaitOne())
            {
                if (COMSerialPort.IsOpen)
                {
                    appendMsg("Get PCB Time: " + Bs2str(data));
                    COMSerialPort.Write(data, 0, data.Length);
                }
                else
                {
                    appendMsg(COMSerialPort.PortName + " is closed.");
                }
                serialAccess.ReleaseMutex();
            }
        }

        private void GetPower_bt_Click(object sender, EventArgs e)
        {
            byte[] data = { 0x03, 0x02, 0x02, 0xff, 0xff, 0xff, 0xff, 0x03, 0xfe };
            string[] ss = TargetID_cb.Text.Split(' ');
            try
            {
                if (data.Length < 4)
                    throw new Exception("Not enough ID length.");
                data[3] = Convert.ToByte(ss[0], 16);
                data[4] = Convert.ToByte(ss[1], 16);
                data[5] = Convert.ToByte(ss[2], 16);
                data[6] = Convert.ToByte(ss[3], 16);
            }
            catch (Exception err)
            {
                appendMsg(err.Message);
                foreach (string s in ss)
                    appendMsg("*" + s);
            }
            if (serialAccess.WaitOne())
            {
                if (COMSerialPort.IsOpen)
                {
                    appendMsg("Get Power: " + Bs2str(data));
                    COMSerialPort.Write(data, 0, data.Length);
                }
                else
                {
                    appendMsg(COMSerialPort.PortName + " is closed.");
                }
                serialAccess.ReleaseMutex();
            }
        }

        private void GetID_bt_Click(object sender, EventArgs e)
        {
            byte[] data = { 0x08, 0x02, 0x02, 0xff, 0xff, 0xff, 0xff, 0x03, 0xfe };
            string[] ss = TargetID_cb.Text.Split(' ');
            try
            {
                if (data.Length < 4)
                    throw new Exception("Not enough ID length.");
                data[3] = Convert.ToByte(ss[0], 16);
                data[4] = Convert.ToByte(ss[1], 16);
                data[5] = Convert.ToByte(ss[2], 16);
                data[6] = Convert.ToByte(ss[3], 16);
            }
            catch (Exception err)
            {
                appendMsg(err.Message);
                foreach (string s in ss)
                    appendMsg("*" + s);
            }
            if (serialAccess.WaitOne())
            {
                if (COMSerialPort.IsOpen)
                {
                    appendMsg("Get ID: " + Bs2str(data));
                    COMSerialPort.Write(data, 0, data.Length);
                }
                else
                {
                    appendMsg(COMSerialPort.PortName + " is closed.");
                }
                serialAccess.ReleaseMutex();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] data = { 0x09, 0x01, 0x02, 0xff, 0xff, 0xff, 0xff, 0x03, 0x02, 0xfe };
            string[] ss = TargetID_cb.Text.Split(' ');
            try
            {
                if (data.Length < 4)
                    throw new Exception("Not enough ID length.");
                data[3] = Convert.ToByte(ss[0], 16);
                data[4] = Convert.ToByte(ss[1], 16);
                data[5] = Convert.ToByte(ss[2], 16);
                data[6] = Convert.ToByte(ss[3], 16);
            }
            catch (Exception err)
            {
                appendMsg(err.Message);
                foreach (string s in ss)
                    appendMsg("*" + s);
            }
            if (serialAccess.WaitOne())
            {
                if (COMSerialPort.IsOpen)
                {
                    appendMsg("Manual Mode Off: " + Bs2str(data));
                    COMSerialPort.Write(data, 0, data.Length);
                }
                else
                {
                    appendMsg(COMSerialPort.PortName + " is closed.");
                }
                serialAccess.ReleaseMutex();
            }
        }

        private void ManualModeOn_bt_Click(object sender, EventArgs e)
        {
            byte[] data = { 0x09, 0x01, 0x02, 0xff, 0xff, 0xff, 0xff, 0x03, 0x01, 0xfe };
            string[] ss = TargetID_cb.Text.Split(' ');
            try
            {
                if (data.Length < 4)
                    throw new Exception("Not enough ID length.");
                data[3] = Convert.ToByte(ss[0], 16);
                data[4] = Convert.ToByte(ss[1], 16);
                data[5] = Convert.ToByte(ss[2], 16);
                data[6] = Convert.ToByte(ss[3], 16);
            }
            catch (Exception err)
            {
                appendMsg(err.Message);
                foreach (string s in ss)
                    appendMsg("*" + s);
            }
            if (serialAccess.WaitOne())
            {
                if (COMSerialPort.IsOpen)
                {
                    appendMsg("Manual Mode On: " + Bs2str(data));
                    COMSerialPort.Write(data, 0, data.Length);
                }
                else
                {
                    appendMsg(COMSerialPort.PortName + " is closed.");
                }
                serialAccess.ReleaseMutex();
            }
        }

        private void GetScheduler_bt_Click(object sender, EventArgs e)
        {
            byte[] data = { 0x07, 0x02, 0x02, 0xff, 0xff, 0xff, 0xff, 0x03, 0xfe };
            string[] ss = TargetID_cb.Text.Split(' ');
            try
            {
                if (data.Length < 4)
                    throw new Exception("Not enough ID length.");
                data[3] = Convert.ToByte(ss[0], 16);
                data[4] = Convert.ToByte(ss[1], 16);
                data[5] = Convert.ToByte(ss[2], 16);
                data[6] = Convert.ToByte(ss[3], 16);
            }
            catch (Exception err)
            {
                appendMsg(err.Message);
                foreach (string s in ss)
                    appendMsg("*" + s);
            }
            if (serialAccess.WaitOne())
            {
                if (COMSerialPort.IsOpen)
                {
                    appendMsg("Get Scheduler: " + Bs2str(data));
                    COMSerialPort.Write(data, 0, data.Length);
                }
                else
                {
                    appendMsg(COMSerialPort.PortName + " is closed.");
                }
                serialAccess.ReleaseMutex();
            }
        }

        private void SearchL1_bt_Click(object sender, EventArgs e)
        {
            byte[] data = { 0x11, 0x02, 0x02, 0xff, 0xff, 0xff, 0xff, 0x03, 0x01, 0xfe };
            if (serialAccess.WaitOne())
            {
                if (COMSerialPort.IsOpen)
                {
                    appendMsg("Search Level 1: " + Bs2str(data));
                    COMSerialPort.Write(data, 0, data.Length);
                }
                else
                {
                    appendMsg(COMSerialPort.PortName + " is closed.");
                }
                serialAccess.ReleaseMutex();
            }
        }

        private void SearchL2_bt_Click(object sender, EventArgs e)
        {
            byte[] data = { 0x11, 0x02, 0x02, 0xff, 0xff, 0xff, 0xff, 0x03, 0x02, 0xfe };
            if (serialAccess.WaitOne())
            {
                if (COMSerialPort.IsOpen)
                {
                    appendMsg("Search Level 2: " + Bs2str(data));
                    COMSerialPort.Write(data, 0, data.Length);
                }
                else
                {
                    appendMsg(COMSerialPort.PortName + " is closed.");
                }
                serialAccess.ReleaseMutex();
            }
        }

        private void SearchL3_bt_Click(object sender, EventArgs e)
        {
            byte[] data = { 0x11, 0x02, 0x02, 0xff, 0xff, 0xff, 0xff, 0x03, 0x03, 0xfe };
            if (serialAccess.WaitOne())
            {
                if (COMSerialPort.IsOpen)
                {
                    appendMsg("Search Level 3: " + Bs2str(data));
                    COMSerialPort.Write(data, 0, data.Length);
                }
                else
                {
                    appendMsg(COMSerialPort.PortName + " is closed.");
                }
                serialAccess.ReleaseMutex();
            }
        }

        private void DevUnpair_bt_Click(object sender, EventArgs e)
        {
            byte[] data = { 0x10, 0x01, 0x02, 0xff, 0xff, 0xff, 0xff, 0x03, 0x02, 0xfe };
            string[] ss = TargetID_cb.Text.Split(' ');
            try
            {
                if (data.Length < 4)
                    throw new Exception("Not enough ID length.");
                data[3] = Convert.ToByte(ss[0], 16);
                data[4] = Convert.ToByte(ss[1], 16);
                data[5] = Convert.ToByte(ss[2], 16);
                data[6] = Convert.ToByte(ss[3], 16);
            }
            catch (Exception err)
            {
                appendMsg(err.Message);
                foreach (string s in ss)
                    appendMsg("*" + s);
            }
            if (serialAccess.WaitOne())
            {
                if (COMSerialPort.IsOpen)
                {
                    appendMsg("Unpair Device: " + Bs2str(data));
                    COMSerialPort.Write(data, 0, data.Length);
                }
                else
                {
                    appendMsg(COMSerialPort.PortName + " is closed.");
                }
                serialAccess.ReleaseMutex();
            }
        }

        private void DevPair_bt_Click(object sender, EventArgs e)
        {
            byte[] data = { 0x10, 0x01, 0x02, 0xff, 0xff, 0xff, 0xff, 0x03, 0x01, 0xfe };
            string[] ss = TargetID_cb.Text.Split(' ');
            try
            {
                if (data.Length < 4)
                    throw new Exception("Not enough ID length.");
                data[3] = Convert.ToByte(ss[0], 16);
                data[4] = Convert.ToByte(ss[1], 16);
                data[5] = Convert.ToByte(ss[2], 16);
                data[6] = Convert.ToByte(ss[3], 16);
            }
            catch (Exception err)
            {
                appendMsg(err.Message);
                foreach (string s in ss)
                    appendMsg("*" + s);
            }
            if (serialAccess.WaitOne())
            {
                if (COMSerialPort.IsOpen)
                {
                    appendMsg("Pair Device: " + Bs2str(data));
                    COMSerialPort.Write(data, 0, data.Length);
                }
                else
                {
                    appendMsg(COMSerialPort.PortName + " is closed.");
                }
                serialAccess.ReleaseMutex();
            }
        }

        private void SetIDToPCB_bt_Click(object sender, EventArgs e)
        {
            byte[] data = { 0x08, 0x55, 0x02, 0xff, 0xff, 0xff, 0xff, 0x03, 0x02, 0, 0, 0, 0, 0xfe };
            string[] ss = IDFromTime_tb.Text.Split(' ');
            try
            {
                data[9] = Convert.ToByte(ss[0], 16);
                data[10] = Convert.ToByte(ss[1], 16);
                data[11] = Convert.ToByte(ss[2], 16);
                data[12] = Convert.ToByte(ss[3], 16);
            }
            catch (Exception err)
            {
                appendMsg(err.Message);
                foreach (string s in ss)
                    appendMsg("*" + s);
            }
            if (serialAccess.WaitOne())
            {
                if (COMSerialPort.IsOpen)
                {
                    appendMsg("Set ID To PCB: " + Bs2str(data));
                    COMSerialPort.Write(data, 0, data.Length);
                }
                else
                {
                    appendMsg(COMSerialPort.PortName + " is closed.");
                }
                serialAccess.ReleaseMutex();
            }
        }

        private void GetIDFromTime_bt_Click(object sender, EventArgs e)
        {
            appendMsg(DateTime.Now.Second.ToString());
            appendMsg(DateTime.Now.Minute.ToString());
            appendMsg(DateTime.Now.Hour.ToString());
            appendMsg(DateTime.Today.Day.ToString());
            appendMsg(DateTime.Today.Month.ToString());
            appendMsg(DateTime.Today.Year.ToString());

            Int32 ID32 = (int)(DateTime.Today.Year / 100) << 27 | (int)(DateTime.Today.Month) << 23 | (int)(DateTime.Today.Day) << 17 |
                (int)(DateTime.Now.Hour) << 12 | (int)(DateTime.Now.Minute) << 6 | (int)(DateTime.Now.Second);
            byte[] IDb = BitConverter.GetBytes(ID32);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(IDb);
            }
            appendMsg(Bs2str(IDb));
            IDFromTime_tb.Text = Bs2str(IDb);
        }
    }
}
