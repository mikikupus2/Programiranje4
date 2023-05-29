using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*proveriti da li je uneti string palindrom(cita se isto i sa leve i sa desne strane ignorisuci razmake)*/
/*napisati program koji proverava da li su 2 stringa anagrami jedan drugom*/
namespace palindromanagram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tba.Text != "" && tbb.Text != "")
            {
                if (Anagram(tba.Text, tbb.Text)) txtanagram.Text = "jesu";
                else txtanagram.Text = "nisu";
            }
            if(tbp.Text != "")
            {
                if (Palindrom(tbp.Text)) txtpalindrom.Text = "jeste";
                else txtpalindrom.Text = "nije";
            }
           
        }
        private bool Anagram(string stringa, string stringb)
        {
            /*string a = txta.Text;
            string b = txtb.Text;
            int j = 0;
            bool odg = true;
            if(a.Length == b.Length)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    j = b.IndexOf(a[i]);
                    if (j > -1)
                    {
                        b = b.Remove(j, 1);
                    }
                    else
                    {
                        odg = false;
                        break;
                    }
                }

            }
            else
                odg = false;
            txtodg.Text = odg.ToString();
            */
            if (stringa.Length != stringb.Length) return false;

            char[] stringaArray = stringa.ToLower().ToCharArray();
            char[] stringbArray = stringb.ToLower().ToCharArray();

            Array.Sort(stringaArray);
            Array.Sort(stringbArray);

            for (int i = 0; i < stringaArray.Length; i++)
                if (stringaArray[i] != stringbArray[i])
                    return false;
            return true;
        }
        private bool Palindrom(string s)
        {
            /*string a, b;
            a = txta.Text;
            b = "";
            for (int i = n - 1; i >= 0; i--)
                b = b + a.Substring(i, 1);
            txtb.Text = b;
            if (String.Compare(a, b) == 0)
                txtodg.Text = "DA";
            else
                txtodg.Text = "NE";*/
            int length = s.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (s[i] != s[length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
