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

namespace datagridview23jan23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand prikazi, brisi;
        SqlDataReader dr;
        DataTable dt;
        string veza;

        private void Form1_Load(object sender, EventArgs e)
        {
            veza = "Data Source=DESKTOP-5P0NV5S\\SQLEXPRESS01;Initial Catalog=Fakultet2019;Integrated Security=True";
            conn = new SqlConnection(veza);
            prikazi = new SqlCommand();
            prikazi.Connection = conn;
            prikazi.CommandText = "SELECT * FROM STUDENT";
            try
            {
                conn.Open();
                dr = prikazi.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                conn.Close();
                dgstudent.DataSource = dt;
            }
            catch(SqlException err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dgstudent_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow izabran;
            if (dgstudent.SelectedRows.Count == 1)
            {
                izabran = dgstudent.SelectedRows[0];
                txtindex.Text = izabran.Cells[0].Value.ToString();
                txtime.Text = izabran.Cells["ime"].Value.ToString();
                txtprezime.Text = izabran.Cells["prezime"].Value.ToString();
                txtgodina.Text = izabran.Cells["godstudija"].Value.ToString();
            }
        }

        private void btbrisi_Click(object sender, EventArgs e)
        {
            if(txtindex.Text != "")
            {
                int brred;
                brisi = new SqlCommand();
                brisi.CommandText = "DELETE FROM STUDENT WHERE brojindeksa = @INDEKS";
                brisi.Parameters.AddWithValue("@INDEKS", txtindex.Text);
                brisi.Connection = conn;
                try
                {
                    conn.Open();
                    brred = brisi.ExecuteNonQuery();
                    if (brred == 1)
                    {
                        txtindex.Text = txtime.Text = txtprezime.Text = txtgodina.Text = "";
                        MessageBox.Show("Red je uspesno obrisan");
                        dgstudent.DataSource = null;
                        dgstudent.Rows.Clear();
                        dt.Clear();
                        dr = prikazi.ExecuteReader();
                        dt.Load(dr);
                        dgstudent.DataSource = dr;
                    }
                    else
                        MessageBox.Show("Brisanje nije uspelo");
                }
                catch (SqlException err)
                {
                    MessageBox.Show(err.Message);
                }
                finally
                {

                }
            }
        }
    }
}
