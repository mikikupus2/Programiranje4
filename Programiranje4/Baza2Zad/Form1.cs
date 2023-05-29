using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq.Expressions;

namespace Baza2Zad
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

        string veza;

        private void btprikazi_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            veza = @" Data Source=DESKTOP-5P0NV5S\SQLEXPRESS01;Initial Catalog=Fakultet2019;Integrated Security=True";
            conn.ConnectionString = veza;
            komanda = new SqlCommand ();
            komanda.Connection = conn;
            komanda.CommandText = " SELECT * FROM STUDENT" + 
                "WHERE godStudija= @Gs  ORDER BY Prezime";

            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                komanda.Parameters.Clear();
                komanda.Parameters.AddWithValue("@Gs", txtgod.Text);
                dr = komanda.ExecuteReader ();
                dt.Load(dr);
                dgstudent.DataSource = dt;
               
            }
            catch (SqlException gr)
            {
                MessageBox.Show (gr.Message);

            }
            finally 
            {
                conn.Close();
            }
        }
    }
}
