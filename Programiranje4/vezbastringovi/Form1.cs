using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
/*U tekstu koji se unosi sa tastature napraviti sledece izmene:
1) Datume iz 2022. godine povecati za 6 meseci.
2) U recima izmedju dva uzastupna suglasnika ubaciti samoglasnik malo a
3) U listboxu prikazati sve brojeve telefona grupe 063 koji se zavrsavaju sa 7*/
namespace vezbastringovi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool brisi = false;
        private void button1_Click(object sender, EventArgs e)
        {
            tbispis.Text = "";
            lbrez.Items.Clear();
            string unostext = tbunos.Text;
            StringBuilder sb = new StringBuilder();
           
            //2)
            string suglasnici = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";
            for (int i = 0; i < unostext.Length; i++)
            {
                char trenutni = unostext[i];
                sb.Append(trenutni);

                if (i < unostext.Length - 1)
                {
                    char sledeci = unostext[i + 1];
                    if (suglasnici.Contains(trenutni) && suglasnici.Contains(sledeci))
                    {
                        sb.Append("a");
                    }
                }
            }
            //1)
            MatchCollection matches = Regex.Matches(sb.ToString(), @"\b\d{2}\-\d{2}\-\d{4}\b");
            foreach(Match match in matches)
            {
                DateTime date = DateTime.ParseExact(match.Value, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                if (date.Year == 2022)
                {
                    date = date.AddMonths(6);
                    sb.Replace(match.Value, date.ToString("dd-MM-yyyy"));

                }
            }
            //3)
            Regex brojevi = new Regex(@"\b063-\d{3}-\d{4}\b");
            lbrez.Items.Add("Brojevi telefona grupe 063 koji se zavrsavaju sa 7");
            foreach (Match match in brojevi.Matches(unostext))
            {
                if (match.Value.EndsWith("7"))
                {
                    lbrez.Items.Add(match.ToString());
                }
            }

            tbispis.Text = sb.ToString();
        }
    }
}
