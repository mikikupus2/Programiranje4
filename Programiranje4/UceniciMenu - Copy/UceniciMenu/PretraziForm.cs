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
    public partial class PretraziForm : Form
    {
        Queue<Ucenik> red_ucenika;
        bool tip_pretrage = false;
        public PretraziForm(Queue<Ucenik> red_ucenika, bool tip_pretrage)
        {
            InitializeComponent();
            this.red_ucenika = red_ucenika;
            this.tip_pretrage = tip_pretrage;
        }

        private void BtTrazi_Click(object sender, EventArgs e)
        {
            if (red_ucenika.Count == 0)
                MessageBox.Show("Red je prazan!!!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (tbpretraga.Text != "")
                {
                    if(tip_pretrage == false)
                    {
                        bool postoji = false;
                        int sifra = 0;
                        bool moze = int.TryParse(tbpretraga.Text, out sifra);
                        if(moze)
                        {
                            foreach (Ucenik uc in red_ucenika)
                            {
                                if (uc.Sifra == sifra && !postoji)
                                {
                                    postoji = true;
                                    lbsifra.Text = "Šifra: " + uc.Sifra.ToString();
                                    lbime.Text = "Ime: " + uc.Ime.ToString();
                                    lbprezime.Text = "Prezime: " + uc.Prezime.ToString();
                                    lbtelefon.Text = "Telefon: " + uc.Telefon.ToString();
                                    lbocena.Text = "Ocena: " + uc.Ocena.ToString();
                                }

                            }
                            if (!postoji)
                            {
                                MessageBox.Show("Ucenik sa ovom sifrom ili prezimenom ne postoji!!!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            postoji = false;
                        }
                        else MessageBox.Show("Niste uneli pravilno sifru!!!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        bool postoji = false;
                        foreach (Ucenik uc in red_ucenika)
                        {
                            if (uc.Prezime == tbpretraga.Text && !postoji)
                            {
                                postoji = true;
                                lbsifra.Text = "Šifra: " + uc.Sifra.ToString();
                                lbime.Text = "Ime: " + uc.Ime.ToString();
                                lbprezime.Text = "Prezime: " + uc.Prezime.ToString();
                                lbtelefon.Text = "Telefon: " + uc.Telefon.ToString();
                                lbocena.Text = "Ocena: " + uc.Ocena.ToString();
                            }

                        }
                        if (!postoji)
                        {
                            MessageBox.Show("Ucenik sa ovom sifrom ili prezimenom ne postoji!!!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        postoji = false;
                    }

                }
            }
        }

        private void PretraziForm_Load(object sender, EventArgs e)
        {
            if(tip_pretrage)
            {
                label1.Text = "Unesite prezime:";
            }
            else
            {
                label1.Text = "Unesite sifru:";
            }
        }
    }
}
