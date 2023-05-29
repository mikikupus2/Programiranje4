using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kontrolaunosa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '-'))
            {
                e.Handled = true;
            }
        }

        private void txt1_Leave(object sender, EventArgs e)
        {
            int a;
            if (txt1.Text != "")
            {
                if (int.TryParse(txt1.Text, out a))
                {
                    if (!(a >= -100 && a <= 100))
                    {
                        MessageBox.Show("Podatka mora biti iz intervala 1 - 100");
                        txt1.Text = "";
                        txt1.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Uneti podataka nije ceo broj");
                    txt1.Text = "";
                    txt1.Focus();
                }
            }
            else
            {
                MessageBox.Show("Podatak mora biti unesen !!!");
                txt1.Text = "";
                txt1.Focus();
            }
        }

        private void txt1_KeyUp(object sender, KeyEventArgs e)
        {
            if(txt1.Text != "")
            {
                if (e.KeyCode == Keys.Enter)
                    SendKeys.Send("{TAB}");
            }
        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '-' || e.KeyChar == '.'))
            {
                e.Handled = true;
                return;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                return;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
                return;
            }
        }

        private void txt2_Leave(object sender, EventArgs e)
        {
            double a;
            if (txt2.Text != "")
            {
                if (double.TryParse(txt2.Text, out a))
                {
                    if (!(a >= -100 && a <= 100))
                    {
                        MessageBox.Show("Podatka mora biti iz intervala -100 - 100");
                        txt2.Text = "";
                        txt2.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Uneti podataka nije ceo broj");
                    txt2.Text = "";
                    txt2.Focus();
                }
            }
            else
            {
                MessageBox.Show("Podatak mora biti unesen !!!");
                txt2.Text = "";
                txt2.Focus();
            }
        }

        private void txt2_KeyUp(object sender, KeyEventArgs e)
        {
            if (txt2.Text != "")
            {
                if (e.KeyCode == Keys.Enter)
                    SendKeys.Send("{TAB}");
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == (Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
        {
            DateTime d1;
            if (!DateTime.TryParse(maskedTextBox1.Text, out d1))
            {
                maskedTextBox1.Text = "";
                maskedTextBox1.Focus();
            }
        }
    }
}
