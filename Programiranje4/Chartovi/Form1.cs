using Chartovi.FirmaDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Chartovi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string veza = @"Data Source=DESKTOP-5P0NV5S\SQLEXPRESS01;Initial Catalog=Firma;Integrated Security=True";
            SqlConnection con = new SqlConnection(veza);
            SqlCommand sql = new SqlCommand();
            sql.CommandText = "SELECT funckija, SUM(brproj) AS Projekti, " +
                " SUM(brsati) AS Sati FROM Ucesce GROUP BY funkcija ORDER BY funckija";
            sql.Connection = con;
            SqlDataReader dr = sql.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            dgv1.DataSource = dt;

            Series s1 = new Series();
            Series s2 = new Series();
            chart1.Series.Add(s1);
            chart1.Series.Add(s2);
            s1.Name = "Sati";
            s2.Name = "Projekti";

            chart1.DataSource = dt;
            chart1.Series["Sati"].XValueMember = "funckija";
            chart1.Series["Sati"].YValueMembers = "Sati";
            chart1.Series["Sati"].ChartType = SeriesChartType.Pie;

            chart1.Series["Projekti"].XValueMember = "funckija";
            chart1.Series["Projekti"].YValueMembers = "Projekti";
            chart1.Series["Projekti"].Color = Color.Red;
            chart1.Series["Projekti"].ChartType = SeriesChartType.Pie;
        }
    }
}
