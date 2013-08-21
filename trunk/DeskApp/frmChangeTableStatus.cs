using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeskApp
{
    public partial class frmChangeTableStatus : Form
    {
        private int status = 0;

        public int GetStatus
        {
            get
            {
                return status;
            }
        }

        public frmChangeTableStatus()
        {
            InitializeComponent();
        }

        private void btn_st0_Click(object sender, EventArgs e)
        {
            status = 0;
            DialogResult = DialogResult.OK;
        }

        private void btn_st1_Click(object sender, EventArgs e)
        {
            status = 1;
            DialogResult = DialogResult.OK;
        }

        private void btn_st3_Click(object sender, EventArgs e)
        {
            status = 3;
            DialogResult = DialogResult.OK;
        }

        private void btn_st4_Click(object sender, EventArgs e)
        {
            status = 4;
            DialogResult = DialogResult.OK;
        }
    }
}
