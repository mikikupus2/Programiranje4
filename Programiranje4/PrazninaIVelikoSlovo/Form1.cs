using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Napisati program koji u tekstu koji se unosi sa tastature svako visestruko pojavljivanje praznina zamenjuje samo jednom prazninom i svako
pocetno slovo reci pretvara u veliko.*/

namespace PrazninaIVelikoSlovo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prepravi();
           
        }
        private void Prepravi()
        {
            if (tbulazni.Text != "")
            {
                StringBuilder izlazni = new StringBuilder();
                string ulazni = tbulazni.Text;
                bool prazan = true;
                foreach (char c in ulazni)
                {
                    if (char.IsWhiteSpace(c))
                    {
                        if (!prazan)
                        {
                            izlazni.Append(' ');
                            prazan = true;
                        }
                    }
                    else
                    {
                        izlazni.Append(c);
                        prazan = false;
                    }
                }
                for (int i = 0; i < izlazni.Length; i++)
                    if (i == 0 || izlazni[i - 1] == ' ')
                        izlazni[i] = char.ToUpper(izlazni[i]);
                tbizlazni.Text = izlazni.ToString();
            }
        }
        private void tbulazni_TextChanged(object sender, EventArgs e)
        {
            if(cbautomatski.Checked) Prepravi();
        }

        private void cbautomatski_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = !(cbautomatski.Checked);
            if(cbautomatski.Checked) Prepravi();
        }

        private void btobrni_Click(object sender, EventArgs e)
        {
            string ulazni = tbulazni.Text;
            string[] recenice = ulazni.Split('.');
            Stack<string> reciStack = new Stack<string>();
            string obrnutitekst = "";
            foreach (string recenica in recenice)
            {
                string[] reci = recenica.Trim().Split(' ');
                foreach (string rec in reci)
                {
                    reciStack.Push(rec);
                }
                string obrnutarecenica = "";
                while (reciStack.Count > 0)
                {
                    obrnutarecenica += reciStack.Pop() + " ";
                }
                obrnutarecenica = obrnutarecenica.Trim();
                obrnutitekst += obrnutarecenica + ". ";
            }

            tbizlazni.Text = obrnutitekst;
        }
    }
}
