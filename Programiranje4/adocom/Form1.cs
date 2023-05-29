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
/*Napisati program koji u okviru datagridview kontrole na formi prikazuje podatke iz baze Fakulet2019 sve podatke o 
studentima iz te tabele koji su na godini studija koja se unosi u textBox na formi. */
namespace adocom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand komanda;
        string constr;
        DataSet ds;
        SqlDataAdapter da;
        private void button1_Click(object sender, EventArgs e)
        {
            //int godina = int.Parse(txtgod.Text);
            string ime = txtgod.Text;
            int brs;
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-5P0NV5S\SQLEXPRESS01;Initial Catalog=TestBaza;Integrated Security=True";

            komanda = new SqlCommand();
            //komanda.CommandText = "SELECT * FROM STUDENT WHERE " + " GodStudija = " + godina.ToString();
            //komanda.CommandText = "SELECT * FROM STUDENT WHERE " + " Ocena = " + godina.ToString();----
            //komanda.CommandText = "SELECT * FROM STUDENT WHERE " + " Ime = '" + ime + "'";
            //komanda.CommandText = "SELECT * FROM STUDENT WHERE " + " Ime = @ime";
            komanda.CommandText = "UPDATE STUDENT SET GodStudija = GodStudija + 1" + " WHERE GodStudija = 1";
            komanda.Parameters.AddWithValue("@ime", ime);
            komanda.Connection = conn;

            //da = new SqlDataAdapter(komanda);

            //ds = new DataSet();
            try
            {
                //da.Fill(ds, "STUDENT");
                //dgvstudent.DataSource = ds.Tables["STUDENT"];
                conn.Open();
                brs = komanda.ExecuteNonQuery();
                conn.Close();
                txtgod.Text = brs.ToString();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
