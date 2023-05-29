using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UceniciMenu
{
    public partial class UnosForma : Form
    {
        Queue<Ucenik> red_ucenika;
        public UnosForma(Queue<Ucenik> red_ucenika)
        {
            InitializeComponent();
            this.red_ucenika = red_ucenika;
        }

        private void BtUnos_Click(object sender, EventArgs e)
        {
            if (red_ucenika.Count < 3)
            {
                bool postoji = false;
                if (txtime.Text != "" && txtprezime.Text != "" && txtsifra.Text != "" && txttelefon.Text != "" && txtocena.Text != "")
                {
                    if (red_ucenika != null)
                    {
                        foreach (Ucenik uc in red_ucenika)
                        {
                            if (txtsifra.Text == uc.Sifra.ToString())
                                postoji = true;
                        }
                        if (!postoji)
                        {
                            red_ucenika.Enqueue(new Ucenik(int.Parse(txtsifra.Text), txtime.Text, txtprezime.Text, txttelefon.Text, int.Parse(txtocena.Text)));
                            txtime.Text = txtprezime.Text = txtsifra.Text = txttelefon.Text = txtocena.Text = "";
                            postoji = false;
                        }
                        else MessageBox.Show("Učenik sa ovom šifrom već postoji!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else MessageBox.Show("Niste lepo uneli podatke!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                red_ucenika.Dequeue();
                bool postoji = false;
                if (txtime.Text != "" && txtprezime.Text != "" && txtsifra.Text != "" && txttelefon.Text != "" && txtocena.Text != "")
                {
                    if (red_ucenika != null)
                    {
                        foreach (Ucenik uc in red_ucenika)
                        {
                            if (txtsifra.Text == uc.Sifra.ToString())
                                postoji = true;
                        }
                        if (!postoji)
                        {
                            red_ucenika.Enqueue(new Ucenik(int.Parse(txtsifra.Text), txtime.Text, txtprezime.Text, txttelefon.Text, int.Parse(txtocena.Text)));
                            txtime.Text = txtprezime.Text = txtsifra.Text = txttelefon.Text = txtocena.Text = "";
                            postoji = false;
                        }
                        else MessageBox.Show("Učenik sa ovom šifrom već postoji!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else MessageBox.Show("Niste lepo uneli podatke!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Close();
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
