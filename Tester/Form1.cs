using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExt;
using System.Threading; 

namespace Tester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DevExt.CashDrawer.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            display(DevExt.PoleDisplayType.Dark);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            display(DevExt.PoleDisplayType.Price);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            display(DevExt.PoleDisplayType.Total);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            display(DevExt.PoleDisplayType.Payment);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            display(DevExt.PoleDisplayType.Change);
        }
        private void display(DevExt.PoleDisplayType type)
        {
            for (int i = 0; i < 9; i++)
            {
                DevExt.PoleDisplayer.Display(i.ToString(), type);
                Thread.Sleep(500);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DevExt.Relay.Switch("COM2", 1, 0xFFFF, RelayType.BYTECTRL);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DevExt.Relay.Switch("COM2", 1, 0x0000, RelayType.BYTECTRL);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DevExt.Relay.Switch("COM2", 1, 1, RelayType.ON);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DevExt.Relay.Switch("COM2", 1, 5, RelayType.ON);
        }
    }
}
