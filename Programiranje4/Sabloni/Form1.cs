using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sabloni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btok_Click(object sender, EventArgs e)
        {
            if(txttekst.Text != "" && txtsablon.Text != "")
            {
                MatchCollection rezultati = Regex.Matches(txttekst.Text, @txtsablon.Text);
                listBox1.Items.Clear();
                foreach (Match match in rezultati)
                {
                    listBox1.Items.Add(match);
                }
            }
            
        }
    }
}
