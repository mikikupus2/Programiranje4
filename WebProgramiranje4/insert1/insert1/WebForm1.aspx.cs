using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
/*
CREATE DATABASE ucenici;
GO
USE ucenici;
GO
CREATE TABLE prosek
(
rb INT PRIMARY KEY,
prezime VARCHAR(50),
prosek real
);
GO
INSERT INTO prosek
VALUES(1,'Srecko Minic',4),
(2,'Marko Markovic',4.5);
GO*/
namespace insert1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string conn = ConfigurationManager.ConnectionStrings["CS2"].ConnectionString.ToString();
        SqlConnection cn;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btinsert_Click(object sender, EventArgs e)
        {
            int r;
            string iip;
            double pr;
            r = int.Parse(tbrb.Text);
            iip = tbime.Text;
            pr = double.Parse(tbprosek.Text);
            cn = new SqlConnection(conn);
            cn.Open();
            string commandText = "INSERT INTO[prosek]([rb],[prezime],[prosek]) VALUES(@rb,@prezime,@prosek)";
            SqlCommand command = new SqlCommand(commandText,cn);
            command.Parameters.Add("@rb",SqlDbType.Int);
            command.Parameters["@rb"].Value = r;
            command.Parameters.Add("@prezime", SqlDbType.Text);
            command.Parameters["@prezime"].Value = iip;
            command.Parameters.Add("@prosek", SqlDbType.Real);
            command.Parameters["@prosek"].Value = pr;
            cn.Close();
            GridView1.DataBind();
        }
    }
}