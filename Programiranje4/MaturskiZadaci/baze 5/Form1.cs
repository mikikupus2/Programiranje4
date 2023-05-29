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
using System.CodeDom;

namespace baze_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand komanda, citaj;
        string veza;
        SqlDataReader dr;
        DataTable dt;
        private void btprikazi_Click(object sender, EventArgs e)
        {
            veza = @"Data Source=DESKTOP-5P0NV5S\SQLEXPRESS01;Initial Catalog=Biblioteka;Integrated Security=True";
            conn = new SqlConnection(veza);
            dt = new DataTable();
            citaj = new SqlCommand();
            citaj.CommandText = "SELECT * FROM CITALAC";
            citaj.Connection = conn;
            try
            {
                conn.Open();
                dr = citaj.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                dgCitalac.DataSource= dt;
            }
            catch (SqlException gr)
            {
                MessageBox.Show(gr.Message);

            }
            finally
            {
                conn.Close();
            }
        }

        private void dgCitalac_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgCitalac_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow red = dgCitalac.SelectedRows[0];
            txtci.Text = red.Cells["CitalacID "].Value.ToString();
            txtmbr.Text = red.Cells[1].Value.ToString();
            txtime.Text = red.Cells[2].Value.ToString();
            txtprezime.Text = red.Cells[3].Value.ToString();
            txtmesto.Text = red.Cells[4].Value.ToString();
            txtadresa.Text = red.Cells[5].Value.ToString();
            txttelefon.Text = red.Cells[6].Value.ToString();
        }

        private void btdodaj_Click(object sender, EventArgs e)
        {
            veza = @"Data Source=DESKTOP-5P0NV5S\SQLEXPRESS01;Initial Catalog=Biblioteka;Integrated Security=True";
            conn = new SqlConnection(veza);
            int n;
            komanda = new SqlCommand();
            komanda.CommandText =
                "INSERT INTO CITALAC (MaticniBroj, Ime, rezime, Mesto, Adresa, Telefon)" +
                "VALUES (@mbr, @ime, @prez, @mesto, @adresa, @tel)";

            komanda.Connection = conn;
            komanda.Parameters.Clear();
            komanda.Parameters.AddWithValue("@mbr", Convert.ToInt32(txtmbr.Text));
            komanda.Parameters.AddWithValue("@ime", txtime);
            komanda.Parameters.AddWithValue("@prez", txtprezime);
            komanda.Parameters.AddWithValue("@mesto", txtprezime);
            komanda.Parameters.AddWithValue("@adresa", txtadresa);
            komanda.Parameters.AddWithValue("@tel", Convert.ToInt32(txttelefon.Text));

            try
            {
                conn.Open();
                n = komanda.ExecuteNonQuery();
                if (n == 1)
                {
                    dgCitalac.DataSource = null;
                    dgCitalac.Rows.Clear();
                    dt = new DataTable();
                    citaj = new SqlCommand();
                    citaj.CommandText = "SELECT * FROM CITALAC";
                    citaj.Connection = conn;
                    dr = citaj.ExecuteReader();
                    dt.Load(dr);
                    dgCitalac.DataSource = dt;

                    MessageBox.Show(" 1 red dodat u tabelu Citalac");

                }
                else
                    MessageBox.Show("Red nije dodat  u tabelu !!!");

            }

            catch(Exception ex) 
            {
                MessageBox.Show (ex.Message);
            }
                
            finally
            {
                conn.Close();
            }

        }
    }
}
