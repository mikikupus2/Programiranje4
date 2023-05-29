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
    public partial class PrikazForma : Form
    {
        Form1 f;
        public PrikazForma(Form1 f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void PrikazForma_Load(object sender, EventArgs e)
        {
            dgvstudenti.DataSource = f.studenti;
        }
    }
}
