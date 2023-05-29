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

namespace BazaBrisanjeListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UcitajPodatkeIzBaze();
        }
        private void UcitajPodatkeIzBaze()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-5P0NV5S\\SQLEXPRESS01;Initial Catalog=Fakultet2019;Integrated Security=True"))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Nastavnik", conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["idNastavnika"].ToString() + " " + reader["Ime"].ToString() + " " + reader["Prezime"].ToString());
                                item.SubItems.Add(reader["idNastavnika"].ToString());
                                item.SubItems.Add(reader["Ime"].ToString());
                                item.SubItems.Add(reader["Prezime"].ToString());
                                listView1.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                tbid.Text = listView1.SelectedItems[0].SubItems[1].Text;
                tbime.Text = listView1.SelectedItems[0].SubItems[2].Text;
                tbprezime.Text = listView1.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (tbid.Text != "" && tbime.Text != "" && tbprezime.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Da li ste sigurni?", "Upozorenje", MessageBoxButtons.OKCancel);
                if(DialogResult.OK == dialog)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-5P0NV5S\\SQLEXPRESS01;Initial Catalog=Fakultet2019;Integrated Security=True"))
                        {
                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand("DELETE FROM nastavnik WHERE idNastavnika=@ID", conn))
                            {
                                cmd.Parameters.Add("@ID", SqlDbType.Int);
                                cmd.Parameters["@ID"].Value = int.Parse(tbid.Text);
                                if(cmd.ExecuteNonQuery() == 1) MessageBox.Show("Nastavnik je obrisan");
                            }
                        }
                        listView1.Items.Clear();
                        UcitajPodatkeIzBaze();
                        tbid.Text = tbime.Text = tbprezime.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
               
            }
            else MessageBox.Show("Niste uneli podatke!!!");
        }
    }
}
