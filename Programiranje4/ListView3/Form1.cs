using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Napisati program koji klikom na komandno dugme prikazuje podatke iz tabela beze u okviru ListView-a*/
namespace ListView3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand komanda;
        SqlDataReader dr;
        DataTable dt;
        string veza;
        private void button1_Click(object sender, EventArgs e)
        {
            veza = @"Data Source=DESKTOP-5P0NV5S\SQLEXPRESS01;Initial Catalog=Fakultet2019;Integrated Security=True";
            conn = new SqlConnection();
            conn.ConnectionString = veza;
            komanda = new SqlCommand();
            string sql = "SELECT * FROM STUDENT";//RADNIK
            komanda.Connection = conn;
            komanda.CommandText = sql;

            lvradnik.GridLines = true;
            lvradnik.Scrollable = true;
            lvradnik.FullRowSelect = true;
            lvradnik.View = View.Tile;

            try
            {
                conn.Open();
                dr = komanda.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                conn.Close();

                lvradnik.Items.Clear();
                //Kreiranje kolona ListView i upisivanje naslova kolone
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    ColumnHeader col = new ColumnHeader();
                    col.Text = dt.Columns[i].Caption;
                    lvradnik.Columns.Add(col);
                }
                //Popunjavanje redova ListView
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem red = new ListViewItem(dt.Rows[i][0].ToString(), i);
                    for (int j = 1; j < dt.Columns.Count; j++)
                    {
                        red.SubItems.Add(dt.Rows[i][j].ToString());
                    }
                    lvradnik.Items.Add(red);
                }
                lvradnik.Show();
            }
            catch(SqlException message)
            {
                MessageBox.Show(message.Message);
            }

        }
    }
}
