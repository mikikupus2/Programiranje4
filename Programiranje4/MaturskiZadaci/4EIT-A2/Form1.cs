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

namespace _4EIT_A2
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
        string veza = @"Data Source=DESKTOP-5P0NV5S\SQLEXPRESS01;Initial Catalog=Biblioteka;Integrated Security=True";
        private void Form1_Load(object sender, EventArgs e)
        {
            UcitajPodatkeIzBaze();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                tbsifra.Text = listView1.SelectedItems[0].SubItems[0].Text;
                tbime.Text = listView1.SelectedItems[0].SubItems[1].Text;
                tbprezime.Text = listView1.SelectedItems[0].SubItems[2].Text;
                tbrodjen.Text = listView1.SelectedItems[0].SubItems[3].Text;
            }
        }
        private void UcitajPodatkeIzBaze()
        {
            conn = new SqlConnection();
            conn.ConnectionString = veza;
            komanda = new SqlCommand();
            string sql = "SELECT * FROM AUTOR";
            komanda.Connection = conn;
            komanda.CommandText = sql;
            listView1.MultiSelect = false;
            listView1.GridLines = true;
            listView1.Scrollable = true;
            listView1.FullRowSelect = true;
            listView1.View = View.Details;

            try
            {
                conn.Open();
                dr = komanda.ExecuteReader();
                dt = new DataTable();
                dt.Load(dr);
                conn.Close();

                listView1.Items.Clear();
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    ColumnHeader col = new ColumnHeader();
                    col.Text = dt.Columns[i].Caption;
                    listView1.Columns.Add(col);
                }

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem red = new ListViewItem(dt.Rows[i][0].ToString(), i);
                    for (int j = 1; j < dt.Columns.Count; j++)
                    {
                        red.SubItems.Add(dt.Rows[i][j].ToString());
                    }
                    listView1.Items.Add(red);
                }
                listView1.Show();
            }
            catch (SqlException message)
            {
                MessageBox.Show(message.Message);
            }

        }
        private void tsbtbrisanje_Click(object sender, EventArgs e)
        {
            if (tbsifra.Text != "" && tbime.Text != "" && tbprezime.Text != "" && tbrodjen.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Da li ste sigurni?", "Upozorenje", MessageBoxButtons.OKCancel);
                if (DialogResult.OK == dialog)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(veza))
                        {
                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand("DELETE FROM Autor WHERE AutorID=@ID", conn))
                            {
                                cmd.Parameters.Add("@ID", SqlDbType.Int);
                                cmd.Parameters["@ID"].Value = int.Parse(tbsifra.Text);
                                if (cmd.ExecuteNonQuery() == 1) MessageBox.Show("Nastavnik je obrisan");
                            }
                        }
                        listView1.Items.Clear();
                        UcitajPodatkeIzBaze();
                        tbsifra.Text = tbime.Text = tbprezime.Text = tbrodjen.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else MessageBox.Show("Niste uneli podatke!!!");
        }

        private void tsbtanaliza_Click(object sender, EventArgs e)
        {
            Form2 forma2 = new Form2();
            forma2.Show();
        }
    }
}
