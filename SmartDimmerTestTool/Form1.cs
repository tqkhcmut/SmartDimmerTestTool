using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartDimmerTestTool
{
    public partial class SmartDimmerTT : Form
    {
        public SmartDimmerTT()
        {
            InitializeComponent();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SerialSetting sSetting = new SerialSetting();
            DialogResult res = sSetting.ShowDialog();
        }
    }
}
