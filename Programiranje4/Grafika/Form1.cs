using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Klikni na formu";
        }
        Point pocetna;
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            /*Random r = new Random();
            this.BackColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            Text = $"Kliknuli ste tacku ({e.X},{e.Y})";
            Graphics graph = CreateGraphics();
            Pen pen = new Pen(Color.Blue);
            graph.DrawLine(pen, 50, 50, 150, 50);*/
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            Graphics graph = CreateGraphics();
            Pen pen = new Pen(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)), 10);
            graph.DrawLine(pen, pocetna, new Point(e.X, e.Y));
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            pocetna = new Point(e.X, e.Y);
            
        }
    }
}
