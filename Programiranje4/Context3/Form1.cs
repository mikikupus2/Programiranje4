using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Context3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KopirajAuB_Click(object sender, EventArgs e)
        {
            txtb.Text = txta.Text;
        }

        private void KopirajBuA_Click(object sender, EventArgs e)
        {
            txta.Text = txtb.Text;
        }
    }
}
