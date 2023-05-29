using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentBaza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Student> studenti;
        private void Form1_Load(object sender, EventArgs e)
        {
            studenti = new List<Student>();
        }
        private void UpdateListBox()
        {
            lbstudenti.Items.Clear();
            foreach(Student student in studenti)
            {
                lbstudenti.Items.Add(student.Brojindeksa.PadLeft(10,' ') + student.Ime.PadLeft(20,' ') + student.Prezime.PadLeft(20,' '));
            }
        }

        private void dODAJToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnosForma unos = new UnosForma(this);
            unos.ShowDialog();
            UpdateListBox();
        }

        private void pRIKAZIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikazForma prikaz = new PrikazForma(this);
            prikaz.ShowDialog();
        }

        private void iZBRISIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studenti.Clear();
            UpdateListBox();
        }

        private void iZBACIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IzbaciForma izbaci = new IzbaciForma(this);
            izbaci.ShowDialog();
            UpdateListBox();
        }

        private void sortirajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbstudenti.Sorted = true;
            UpdateListBox();
        }
    }
}
