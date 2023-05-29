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

namespace TypedDS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dss dsfakultet = new dss();
            SqlConnection conn = new SqlConnection();
            SqlCommand selstudent = new SqlCommand("SELECT * FROM STUDENT");
            SqlDataAdapter da = new SqlDataAdapter(selstudent);
            da.Fill(dsfakultet.student);

            dsfakultet.student[0].ime = "Marko";


            DataSet ds = new DataSet(); //netipski dataset, prazan
            da.Fill(ds, "Student"); // "Brucos"
        }
    }
}
