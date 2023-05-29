using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace reverse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                char[] niz = textBox1.Text.ToCharArray();
                Array.Reverse(niz);
                textBox1.Text = new string(niz);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tekst = textBox1.Text;
            string[] niz_recenica = tekst.Split('.');
            textBox1.Text = "";
            foreach(string s in niz_recenica)
            {
                if(s != "")
                    textBox1.Text += s[0].ToString().ToUpper() + s.Substring(1) + Environment.NewLine;
            }
        }
        /*U stringu svako slovo posle tacke postaje veliko, izdvojiti recenice u niz stringova*/
    }
}
