using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace izrazi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            MatchCollection rezultat =
            Regex.Matches(textBox1.Text, textBox2.Text);
            foreach (Match r in rezultat)  
                listBox1.Items.Add(r);  
        }
    }
}
