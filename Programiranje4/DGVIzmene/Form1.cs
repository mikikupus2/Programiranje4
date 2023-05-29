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
/*Omoguciti pregled i izmenu nekog podatka za neku tabelu baze podataka. Podatke prikazati u okviru DGV na formi. Za pregled i prihvatanje izmena postaviti na formu
2 komandna dugmeta prikazi i sacuvaj.*/
namespace DGVIzmene
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand komanda;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cb;
        string constr = "";
        private void btprikazi_Click(object sender, EventArgs e)
        {
            constr = @"Data Source=DESKTOP-5P0NV5S\SQLEXPRESS01;Initial Catalog=Fakultet2019;Integrated Security=True";
            conn = new SqlConnection(constr);
            komanda = new SqlCommand();
            komanda.Connection = conn;
            komanda.CommandText = "SELECT * FROM Student";
            da = new SqlDataAdapter(komanda);
            cb = new SqlCommandBuilder(da);
            ds = new DataSet();

            try
            {
                da.Fill(ds, "Student");
                dgv1.DataSource = ds.Tables["Student"];
            }
            catch(SqlException ex)
            {

            }
            finally
            {

            }
        }

        private void btsnimi_Click(object sender, EventArgs e)
        {
            da.Update(ds.Tables[0]);
        }
    }
}
