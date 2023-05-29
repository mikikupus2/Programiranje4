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

namespace StudentBaza
{
    public partial class UnosForma : Form
    {
        Form1 f;
        public UnosForma(Form1 f)
        {
            InitializeComponent();
            this.f = f;
        }
        SqlConnection conn;
        SqlCommand komanda;
        SqlDataReader dr;
        DataTable dt;
        string veza;
        private void btizvrsi_Click(object sender, EventArgs e)
        {
            Student s;
            veza = @"Data Source=DESKTOP-5P0NV5S\SQLEXPRESS01;Initial Catalog=Fakultet2019;Integrated Security=True";
            conn = new SqlConnection(veza);
            komanda = new SqlCommand(SQLtekst.Text, conn);
            dt = new DataTable();
            try
            {
                conn.Open();
                dr = komanda.ExecuteReader();
                dt.Load(dr);
                foreach(DataRow red in dt.Rows)
                {
                    s = new Student();
                    s.Brojindeksa = red["brojindeksa"].ToString();
                    s.Ime = red["ime"].ToString();
                    s.Prezime = red["prezime"].ToString();
                    s.Adresa = red["adresa"].ToString();
                    s.Godinastudija = (byte)red["godstudija"];
                    s.Datumrodjenja = (DateTime)red["datumrodjenja"];
                    s.Ptt = (long)red["ptt"];
                    f.studenti.Add(s);
                }
                MessageBox.Show("Podaci su dodati u listu");
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            { conn.Close(); }
        }
    }
}
