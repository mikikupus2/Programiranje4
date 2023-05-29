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
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentiChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand komanda;
        SqlDataReader dr;
        DataTable dt;
        string veza;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                veza = @"Data Source=DESKTOP-5P0NV5S\SQLEXPRESS01;Initial Catalog=Fakultet2019;Integrated Security=True";
                con = new SqlConnection();
                con.ConnectionString = veza;
                string sql = "SELECT godStudija,COUNT(brojIndeksa) as brojStudenata FROM student GROUP BY godStudija;";
                komanda = new SqlCommand();
                komanda.Connection = con;
                komanda.CommandText = sql;

                listView1.GridLines = true;
                listView1.Scrollable = true;
                listView1.FullRowSelect = true;
                listView1.View = View.Details;
                con.Open();
                dr = komanda.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                con.Close();

                listView1.Items.Clear();
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    ColumnHeader col = new ColumnHeader();
                    col.Text = dt.Columns[i].Caption;
                    listView1.Columns.Add(col);
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem red = new ListViewItem(dt.Rows[i][0].ToString(), i);
                    for (int j = 1; j < dt.Columns.Count; j++)
                    {
                        red.SubItems.Add(dt.Rows[i][j].ToString());
                    }
                    listView1.Items.Add(red);
                }
                listView1.Show();
            }
            catch (SqlException message)
            {
                MessageBox.Show(message.Message);
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex == 1)
            {
                try
                {
                    veza = @"Data Source=DESKTOP-5P0NV5S\SQLEXPRESS01;Initial Catalog=Fakultet2019;Integrated Security=True";
                    con = new SqlConnection();
                    con.ConnectionString = veza;
                    string sql = "SELECT godStudija,COUNT(brojIndeksa) as brojStudenata FROM student GROUP BY godStudija;";
                    komanda = new SqlCommand();
                    komanda.Connection = con;
                    komanda.CommandText = sql;

                    listView1.GridLines = true;
                    listView1.Scrollable = true;
                    listView1.FullRowSelect = true;
                    listView1.View = View.Tile;
                    con.Open();
                    dr = komanda.ExecuteReader();
                    dt = new DataTable();
                    dt.Load(dr);
                    con.Close();
                    string[] XPointMember = new string[dt.Rows.Count];
                    int[] YPointMember = new int[dt.Rows.Count];

                    for (int count = 0; count < dt.Rows.Count; count++)
                    {
                        //storing Values for X axis  
                        XPointMember[count] = dt.Rows[count]["Quarter"].ToString();
                        //storing values for Y Axis  
                        YPointMember[count] = Convert.ToInt32(dt.Rows[count]["SalesValue"]);

                    }
                    chart1.Series[0].Points.DataBindXY(XPointMember, YPointMember);

                    //Setting width of line  
                    chart1.Series[0].BorderWidth = 10;
                    //setting Chart type   
                    chart1.Series[0].ChartType = SeriesChartType.Pie;
                    foreach (Series charts in chart1.Series)
                    {
                        foreach (DataPoint point in charts.Points)
                        {
                            switch (point.AxisLabel)
                            {
                                case "Q1": point.Color = Color.RoyalBlue; break;
                                case "Q2": point.Color = Color.SaddleBrown; break;
                                case "Q3": point.Color = Color.SpringGreen; break;
                            }
                            point.Label = string.Format("{0:0} - {1}", point.YValues[0], point.AxisLabel);

                        }
                    }
                }
                catch (SqlException message)
                {
                    MessageBox.Show(message.Message);
                }
            }
        }
    }
}
