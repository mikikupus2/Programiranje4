using Connect.TestBazaDataSetTableAdapters;
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
namespace Connect
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
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=DESKTOP-5P0NV5S\SQLEXPRESS01;Initial Catalog=TestBaza;Integrated Security=True";

            komanda = new SqlCommand();
            komanda.Connection = conn;
            komanda.CommandText = "SELECT * FROM Student";

            da = new SqlDataAdapter(komanda);

            cb = new SqlCommandBuilder(da);

            ds = new DataSet();
            try
            {
                //conn.Open();
                da.Fill(ds, "Student");
            }
            catch (SqlException gr)
            {
                MessageBox.Show(gr.Message);
            }
            finally
            {
                conn.Close();
            }
            dataGridView1.DataSource = ds.Tables["Student"]; //ds.Tables[0];
            /*StudentTableAdapter adapter = new StudentTableAdapter();
            adapter.Fill(testBazaDataSet.Student);*/
        }
    }
}
