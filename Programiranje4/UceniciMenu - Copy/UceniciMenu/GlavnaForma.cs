using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*U okviru genericke liste nalaze se elementi koji predstavljaku objekte klase Ucneik(sifra, ime, prezime, telefon, ocena iz programiranja)
Omoguciti operacije sa listom:
1)Dodavanje novog elementa
2)Prikaz i Uklanjanje iz liste ucenika sa odgovarajucom sifrom
3)Pregled liste
4)Izracunavanje i prikaz prosecne ocene iz programiranja
Podatke o uceniku uvek prikazivati na posebnoj formi.
Za aktiviranje svih opcija aktivirati glavni meni, a za dodavanje i izbacivanje iz liste
na paletu sa alatkama postaviti odgovarajucu kontrolu.
U listi mzoe biti maksimalno 30 ucenika.*/
/*Queue
 Maksimalno 3
Ukoliko nema mesta u redu, izbaciti jedan element,
Prikaz elemenata u listBox
u ListBox dodati contextmenu koji ima opcije za pretrazivanje reda po sifri ucenika ili po prezimenu.
Podatke o uceniku prikazati na drugoj formi.*/
namespace UceniciMenu
{
    public partial class GlavnaForma : Form
    {
        public GlavnaForma()
        {
            InitializeComponent();
        }
        Queue<Ucenik> red_ucenika;
        private void Form1_Load(object sender, EventArgs e)
        {
            red_ucenika = new Queue<Ucenik>();
        }

        private void BtUnos_Click(object sender, EventArgs e)
        {
            UnosForma unos = new UnosForma(red_ucenika);
            toolStripProsecnaOcena.Text = "Prosečna ocena: " + Ucenik.Prosecna_ocena.ToString();
            UpdateListBox();
        }

        private void toolStripSearch_Click(object sender, EventArgs e)
        {
            bool postoji = false;
            if(toolStripTxtSifra.Text != "")
            {
                foreach (Ucenik uc in red_ucenika)
                {
                    if (uc.Sifra == int.Parse(toolStripTxtSifra.Text))
                    {
                        postoji = true;
                        UcenikForm ucform = new UcenikForm(uc);
                        ucform.ShowDialog();
                    }
                }
                if(!postoji)
                    MessageBox.Show("Ucenik ne postoji!!!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Niste uneli sifru!!!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void toolStripDelete_Click(object sender, EventArgs e)
        {
            if (red_ucenika.Count != 0)
            {
                DialogResult result = MessageBox.Show("Zelite brisanje!!!", "Upozorenje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if(result == DialogResult.Yes)
                {
                    Ucenik.Broj_ucenika -= 1;
                    Ucenik.Ocena_ukupno -= red_ucenika.Peek().Ocena;
                    Ucenik.IzracunajProsecnuOcenu();
                    red_ucenika.Dequeue();
                    UpdateListBox();
                    toolStripTxtSifra.Text = "";
                    toolStripProsecnaOcena.Text = "Prosečna ocena: " + Ucenik.Prosecna_ocena.ToString();
                }
            }
            else MessageBox.Show("Red je prazan!!!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
        }
        private void UpdateListBox()
        {
            lbucenici.Items.Clear();
            foreach(Ucenik uc in red_ucenika)
            {
                lbucenici.Items.Add(uc.Sifra + ", " + uc.Ime + " " + uc.Prezime + ", " + uc.Telefon + ", " + uc.Ocena);
            }
        }
        private void UnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnosForma unos = new UnosForma(red_ucenika);
            unos.ShowDialog();
            toolStripProsecnaOcena.Text = "Prosečna ocena: " + Ucenik.Prosecna_ocena.ToString();
            UpdateListBox();
        }
        private void ListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbucenici.Visible = !lbucenici.Visible;
            ListaToolStripMenuItem.Checked = lbucenici.Visible;
        }
        private void ProsecnaOcenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripProsecnaOcena.Visible = !toolStripProsecnaOcena.Visible;
            ProsecnaOcenaToolStripMenuItem.Checked = toolStripProsecnaOcena.Visible;

        }

        private void pretraziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (red_ucenika.Count == 0)
                MessageBox.Show("Red je prazan!!!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (toolStripSifraPrezime.Text != "")
                {
                    bool postoji = false;
                    lbucenici.Items.Clear();
                    foreach (Ucenik uc in red_ucenika)
                    {
                        int sifra;
                        bool moze = int.TryParse(toolStripSifraPrezime.Text, out sifra);
                        if (uc.Prezime == toolStripSifraPrezime.Text || moze == true && uc.Sifra == sifra)
                        {
                            postoji = true;
                            lbucenici.Items.Add(uc.Sifra + ", " + uc.Ime + " " + uc.Prezime + ", " + uc.Telefon + ", " + uc.Ocena);
                        }

                    }
                    if (!postoji)
                    {
                        MessageBox.Show("Ucenik sa ovom sifrom ili prezimenom ne postoji!!!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lbucenici.Items.Clear();
                        foreach (Ucenik uc in red_ucenika)
                            lbucenici.Items.Add(uc.Sifra + ", " + uc.Ime + " " + uc.Prezime + ", " + uc.Telefon + ", " + uc.Ocena);
                    }
                    postoji = false;
                }
            }
           
            
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(red_ucenika.Count == 0)
                MessageBox.Show("Red je prazan!!!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                lbucenici.Items.Clear();
                foreach (Ucenik uc in red_ucenika)
                    lbucenici.Items.Add(uc.Sifra + ", " + uc.Ime + " " + uc.Prezime + ", " + uc.Telefon + ", " + uc.Ocena);
            }
        }

        private void pretragaPoSifriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PretraziForm pretraziForm = new PretraziForm(red_ucenika, false);
            pretraziForm.Show();
        }

        private void pretragaPoPrezimenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PretraziForm pretraziForm = new PretraziForm(red_ucenika, true);
            pretraziForm.Show();
        }
    }
}
