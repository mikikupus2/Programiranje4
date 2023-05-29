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

namespace Kontrolni_Todor_Simic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlCommand kom;
        SqlConnection conn;
        string veza;
        SqlDataReader dr;
        DataTable dt;

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(veza);
            kom = new SqlCommand();
            veza = @"Data Source=DESKTOP-5P0NV5S\SQLEXPRESS01; Initial Catalog = Fakultet2019;Integrated Security=True";
            conn.ConnectionString = veza;
            dt = new DataTable();
            {
                conn.Open();
                kom.CommandText = "Select idNastavnika,ime,prezime,idPredmeta,nazivPredmeta FROM predmet JOIN nastavnik";

                kom.Connection = conn;
                dr = kom.ExecuteReader();
                dt.Rows.Clear();
                dt.Load(dr);
                
                
            }

        }
    }
}
