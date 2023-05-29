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
using System.Data.SqlClient;
namespace Kontrolni_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand komanda, citaj;
        SqlDataAdapter da;
        string veza;
        SqlCommandBuilder cb;
        DataSet ds;

        private void btprikazi_Click(object sender, EventArgs e)
        {
            komanda = new SqlCommand(); 
            komanda.Connection = conn;
            da = new SqlDataAdapter(komanda);
            cb = new SqlCommandBuilder(da);
            komanda.CommandText = " SELECT S.brojIndeksa, S.ime, S.prezime, P.idPredmeta" +
                " FROM Student S INNER JOIN slusa R ON S.brojIndeksa = R.brojIndeksa" +
                "INNER JOIN Predmet P ON R.idPredmeta= P.idPredmeta"+
                " ORDER BY S.brojIndeksa, S.Ime, S.Prezime, P.idPredmeta";

            try
            {
                da.Fill(ds, "Predmeti");
                dgstudent.DataSource = ds.Tables["Predmeti"];
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

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            veza = @"Data Source=DESKTOP-5P0NV5S\SQLEXPRESS01;Initial Catalog=Fakultet2019;Integrated Security=True";
            conn.ConnectionString = veza;

            ds = new DataSet();
            
        }

    }
}
