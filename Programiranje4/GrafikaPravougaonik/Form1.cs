using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Genericka list sadrzi
 cele brojeve iz intervala  od 1 do 10, maksimalan kapacitet liste je 5 elementa
omoguciti dodavanje elemenata u listu i brisanje cele liste.
na svakih 500 ms aktivira se timer koji sadrzaj liste prikazuej graficki tako sto za svaki element crta pravougaonik popunjen
plavom bojom visine koja je srazmerna njegovoj vrednosti a najveci element u listi prikazuje crvenom bojom.*/
namespace GrafikaPravougaonik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> lista_elemenata = new List<int>();
        Graphics g;
        Brush b;
        int x = 300;
        int y = 30;
        int height = 30;
        int j = 4;
        int xp = 200;
        int yp = 400;
        bool nacrtano = false;
        Color[] boje = new Color[] { Color.Blue, Color.Red };

        private void btdodaj_Click(object sender, EventArgs e)
        {
            if (txtelement.Text != "" && lista_elemenata.Count < 5)
            {
                if (int.Parse(txtelement.Text) < 1 || int.Parse(txtelement.Text) > 10)
                        MessageBox.Show("GRESKAAA");
                else
                {
                        lista_elemenata.Add(int.Parse(txtelement.Text));
                        txtelement.Text = "";
                        Text = lista_elemenata.Count.ToString();
                }
            }  
        }
        private void DodajPravougaonik()
        {
            if(lista_elemenata != null)
            {
                if (lista_elemenata.Count <= 5)
                {
                    int i = 0;
                    xp = 200;
                    foreach (int vrednost in lista_elemenata)
                    {
                        if(vrednost == lista_elemenata.Max())
                            b = new SolidBrush(boje[1]);
                        else
                            b = new SolidBrush(boje[0]);
                        g.FillRectangle(b, xp, yp - (vrednost * 30), 30, (vrednost * 30));
                        xp += 30;
                    }
                }
            }
        } 

        private void timer1_Tick(object sender, EventArgs e)
        {
            DodajPravougaonik();
            xp = 200;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (!nacrtano)
            {
                g.Clear(Color.White);
                nacrtano = true;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            g = CreateGraphics();
            Text = lista_elemenata.Count.ToString();
        }

        private void btobrisi_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            lista_elemenata.Clear();
            Text = lista_elemenata.Count.ToString();
        }
    }
}
