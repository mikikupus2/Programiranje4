using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafikaTekst
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
        Font f1;
        Color b;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            fd1.ShowColor = true;
            fd1.ShowApply = true;
            fd1.ShowEffects = true;
            if(fd1.ShowDialog() != DialogResult.Cancel)
            {
                f1 = fd1.Font;
                b = fd1.Color;
            }
            //f1 = new Font("Helvetica", 40, FontStyle.Italic);
            Brush c1 = new SolidBrush(b);
            Graphics g = this.CreateGraphics();
            g.DrawString("Hello MS Reloaded", f1, c1, 20, 20);
        }
        
    }
}
