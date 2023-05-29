using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GrafikaSlusa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        Brush b;
        int xp = 100;
        int yp = 400;
        SqlConnection con;
        SqlCommand komanda;
        SqlDataReader dr;
        DataTable dt;
        string veza;
        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            try
            {
                veza = @"Data Source=DESKTOP-5P0NV5S\SQLEXPRESS01;Initial Catalog=Fakultet2019;Integrated Security=True";
                con = new SqlConnection();
                con.ConnectionString = veza;
                string sql = "SELECT COUNT(brojIndeksa) as BS FROM slusa GROUP BY idPredmeta;";
                komanda = new SqlCommand();
                komanda.Connection = con;
                komanda.CommandText = sql;
                con.Open();
                dr = komanda.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                con.Close();
            }
            catch (SqlException message)
            {
                MessageBox.Show(message.Message);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            NacrtajChart();
        }
        private void NacrtajChart()
        {
            b = new SolidBrush(Color.Blue);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int a = int.Parse(dt.Rows[i]["BS"].ToString());
                g.FillRectangle(b, xp, yp - (a * 30), 30, (a * 30));
                g.DrawString(a.ToString(), new Font("Arial", 16), b, new Rectangle(xp, yp - (a * 30 + 25), 0, 0), null);
                g.DrawString((i + 1).ToString(), new Font("Arial", 16), b, new Rectangle(xp, yp, 0, 0), null);
                xp += 40;
            }
        }
    }
}
