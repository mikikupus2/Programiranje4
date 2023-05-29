using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mb3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a, b, c;

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Otvaranje fajla!");
        }

        private void btplus_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txta.Text, out a))
            {
                MessageBox.Show("Podaci moraju biti Numericki", "Form1", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txta.Focus();
            }
            else if (!int.TryParse(txtb.Text, out b))
            {
                MessageBox.Show("Podaci moraju biti Numericki", "Form1", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtb.Focus();
            }
            else
            {
                c = a + b;
                lbrez.Text = c.ToString();
            }
        }
    }
}
