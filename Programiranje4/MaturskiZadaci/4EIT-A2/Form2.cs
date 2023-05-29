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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _4EIT_A2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlCommand komanda;
        SqlDataReader dr;
        DataTable dt;
        string veza = @"Data Source=DESKTOP-5P0NV5S\SQLEXPRESS01;Initial Catalog=Biblioteka;Integrated Security=True";
        string commandText = "SELECT YEAR(N.DatumUzimanja), COUNT(N.KnjigaID) FROM Na_citanju N INNER JOIN Napisali S ON N.KnjigaID = S.KnjigaID INNER JOIN Autor A ON s.AutorID = A.AutorID WHERE A.AutorID = @AID GROUP BY YEAR(N.DatumUzimanja) HAVING YEAR(DatumUzimanja) >= @G1 AND YEAR(DatumUzimanja) <= @G2 ORDER BY YEAR(DatumUzimanja)";
        private void btprikazi_Click(object sender, EventArgs e)
        {
            /*

            komanda.Parameters.Add("@ID", SqlDbType.Int);
            komanda.Parameters["@ID"].Value = int.Parse(tbsifra.Text);
            try
            {
                conn.Open();
                dr = komanda.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                conn.Close();
                dataGridView1.DataSource = dt;
            }
            catch (SqlException message)
            {
                MessageBox.Show(message.Message);
            }*/
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString = veza;
            komanda = new SqlCommand();
            komanda.Connection = conn;
            komanda.CommandText = "SELECT AutorID, (Prezime+Ime) AS PIME FROM Autor";
            try
            {
                conn.Open();
                dr = komanda.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                conn.Close();
                cmb.DataSource = dt;
                cmb.DisplayMember = dt.Columns["PIME"].ToString();
                cmb.ValueMember = dt.Columns["AutorID"].ToString();
            }
            catch (SqlException message)
            {
                MessageBox.Show(message.Message);
            }
        }

        private void cmb_SelectionChangeCommitted(object sender, EventArgs e)
        { 
            int Aid = int.Parse(cmb.SelectedValue.ToString());
            int G2 = DateTime.Now.Year;
            int G1 = G2 - 10;
        }
    }
}
