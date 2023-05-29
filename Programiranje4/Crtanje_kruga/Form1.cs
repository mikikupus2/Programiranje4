using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Crtanje_kruga
{
    public partial class Form1 : Form
    {
        int interval = 1000;
        int pogodak = 0;
        int R = 200;
        bool kraj = false;
        Random r = new Random();
        Graphics graphics;
        SolidBrush brush;
        Pen pen;
        int xc;
        int yc;
        int x;
        int y;
        bool moze = true;
        public Form1()
        {
            InitializeComponent();
           
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            graphics = CreateGraphics();
            brush = new SolidBrush(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)));
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            /*Random s1 = new Random();
            Graphics g = CreateGraphics();
            SolidBrush cetka = new SolidBrush(Color.FromArgb(s1.Next(256), s1.Next(256), s1.Next(256)));
            int R = s1.Next(20,101);
            int xc = e.X;
            int yc = e.Y;
            int x = xc - R / 2;
            int y = yc - R / 2;
            g.FillEllipse(cetka, x, y, R, R);*/

            double d = Math.Sqrt((e.X - xc)* (e.X - xc) + (e.Y - yc) * (e.Y - yc));
            double d2 = Math.Sqrt((e.X + xc)* (e.X + xc) - (e.Y + yc) * (e.Y + yc));
            if (d <= R / 2 || d2 <= R / 2)
            {
                pogodak += 1;
                moze = true;
                R -= 10;
                timer1.Interval += 10;
                Text = pogodak.ToString();
                KreirajKrug();
            }

        }
        //int R = 20;


        private void timer1_Tick(object sender, EventArgs e)
        {
            if(moze)
            {
                KreirajKrug();
            }
            /*Random s1 = new Random();
            Graphics g = CreateGraphics();
            SolidBrush cetka = new SolidBrush(Color.FromArgb(s1.Next(256), s1.Next(256), s1.Next(256)));
            int R = s1.Next(20, 101);
            int x = s1.Next(ClientRectangle.Width);
            int y = s1.Next(ClientRectangle.Height);
            if (x + R <= ClientRectangle.Width && y + R <= ClientRectangle.Height)
                g.FillEllipse(cetka, x, y, R, R);*/
            /*Random r = new Random();
            Graphics graph = CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)));
            Pen pen = new Pen(brush, 3);
            int xc = ClientRectangle.Width / 2;
            int yc = ClientRectangle.Height / 2;
            int x = xc - R / 2;
            int y = yc - R / 2;
            graph.DrawEllipse(pen, x, y, R, R);
            R += 10;
            if (timer1.Interval > 100)
                timer1.Interval -= 100;
            if (R > ClientRectangle.Height || R > ClientRectangle.Width)
                timer1.Enabled = false; */

        }

        private void KreirajKrug()
        {
            graphics.Clear(Color.White);
            brush = new SolidBrush(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)));
            xc = r.Next(ClientRectangle.Width - R);
            yc = 0;
            graphics.FillEllipse(brush, xc, yc, R, R);
            moze = false;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
