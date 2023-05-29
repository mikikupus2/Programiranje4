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
    public partial class IzbaciForma : Form
    {
        Form1 f;
        public IzbaciForma(Form1 f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void btizbaci_Click(object sender, EventArgs e)
        {
            bool nadjen = false;
            Student s = null;
            foreach(Student student in f.studenti)
            {
                if (student.Brojindeksa == txtbri.Text)
                {
                    s = student;
                    MessageBox.Show("Student obrisan");
                    nadjen = true;
                }
            }
            if(nadjen)
                f.studenti.Remove(s);
            if (!nadjen)
                MessageBox.Show("Student sa tim brojem indeksa ne postoji!");
        }
    }
}
