using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace sredinakrug
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        Color color = Color.Red;
        Brush brush;
        float R = 50f;
        float xstart;
        float ystart;
        float xend;
        float yend;
        float x = 0;
        float y = 0;
        float k = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            xstart = ClientRectangle.Width / 2 - R/2;
            ystart = 0;
            xend = ClientRectangle.Width - R;
            yend = ClientRectangle.Height - R;
            brush = new SolidBrush(color);
            x = xstart;
            y = ystart;
            k = (yend - y) / (xend - x);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (y + 5 < yend - R)
            {
                g.Clear(Color.White);
                y = y + 5;
                x = y / k + xstart;
                g.FillEllipse(brush, x, y, R, R);
            }
            else
                timer1.Enabled = false;
        }
    }
}
