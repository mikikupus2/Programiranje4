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
/*Napsati program koji u okviru kontrole GridView na formi prikazuje podatke 
 * iz baze biblioteka o citaocima iz beograda. Forma ima 3 taba*/
namespace DataReaderR
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
        string sql;
        private void btprikazi_Click(object sender, EventArgs e)
        {
            veza = @"Data Source=DESKTOP-5P0NV5S\SQLEXPRESS01;Initial Catalog=TestBaza;Integrated Security=True";
            conn = new SqlConnection(veza);
            string mesto = txtmesto.Text;

            /*(string sql = "SELECT * FROM STUDENT WHERE OCENA = 10";
            string sql = "SELECT * FROM STUDENT WHERE OCENA ="+ mesto;)*/

            //string sql = "SELECT * FROM CITALAC WHERE MESTO = 'Beograd'";
            //string sql = "SELECT * FROM CITALAC WHERE MESTO = '" + mesto + "'";

            //string sql = "SELECT * FROM CITALAC WHERE MESTO = @mesto";
            sql = "SELECT * FROM CITALAC WHERE MESTO = @mesto";
            komanda = new SqlCommand(sql,conn);
            komanda.Parameters.AddWithValue("@mesto", mesto);
            dt = new DataTable();

            try
            {
                conn.Open();
                dr = komanda.ExecuteReader();
                dt.Load(dr);
                dGVCitaoci.DataSource = dt;
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

        private void tabbibl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabbibl.SelectedIndex == 0)
            {
                //sql = "SELECT * FROM CITALAC";
                sql = "SELECT * FROM STUDENT";
            }
            else if(tabbibl.SelectedIndex == 1)
            {
                //sql = "SELECT * FROM AUTOR";
                sql = "SELECT * FROM STUDENT";
            }
            else
            {
                //sql = "SELECT * FROM KNJIGA";
                sql = "SELECT * FROM STUDENT";
            }
            komanda = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                dr = komanda.ExecuteReader();
                dt.Load(dr);
                dGVCitaoci.DataSource = dt;
            }
            catch (SqlException ex)
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
            veza = @"Data Source=DESKTOP-5P0NV5S\SQLEXPRESS01;Initial Catalog=TestBaza;Integrated Security=True";
            conn = new SqlConnection(veza);
            komanda = new SqlCommand(sql, conn);
            dt = new DataTable();
            tabbibl.SelectedIndex = 1;
            tabbibl.SelectedIndex = 0;
        }
    }
}
