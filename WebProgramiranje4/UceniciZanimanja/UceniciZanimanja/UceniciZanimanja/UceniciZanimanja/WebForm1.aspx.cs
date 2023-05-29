using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/*
 CREATE DATABASE ucenici;
GO
USE ucenici;
GO
CREATE TABLE Zanimanja
(
	tb INT NOT NULL,
	preziime VARCHAR(50) NOT NULL,
	pol VARCHAR(10) NOT NULL,
	razred SMALLINT NOT NULL,
	zanimanje VARCHAR(50) NOT NULL
);*/
namespace UceniciZanimanja
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string conn = ConfigurationManager.ConnectionStrings["UceniciConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btinsert_Click(object sender, EventArgs e)
        {
            int rb = int.Parse(tbrb.Text);
            string preziime = tbpreziime.Text;
            string pol = ddlpol.SelectedValue;
            int razred = int.Parse(tbrazred.Text);
            string zanimanje = ddlzanimanje.SelectedValue;
            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            string commandText = "INSERT INTO [Zanimanja] ([rb], [prezziime], [pol], [razred], [zanimanje]) VALUES (@rb, @preziime, @pol, @razred, @zanimanje)";
            SqlCommand command = new SqlCommand(commandText, connection);
            command.Parameters.Add("@rb", SqlDbType.Int);
            command.Parameters["@rb"].Value = rb;

            command.Parameters.Add("@preziime", SqlDbType.VarChar);
            command.Parameters["@preziime"].Value = preziime;

            command.Parameters.Add("@pol", SqlDbType.VarChar);
            command.Parameters["@pol"].Value = pol;

            command.Parameters.Add("@razred", SqlDbType.Int);
            command.Parameters["@razred"].Value = razred;

            command.Parameters.Add("@zanimanje", SqlDbType.VarChar);
            command.Parameters["@zanimanje"].Value = zanimanje;

            command.ExecuteNonQuery();
            GridView1.DataBind();
        }

        protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
        {
            if(e.SortExpression == "rb" || e.SortExpression == "pol" || e.SortExpression == "zanimanje")
            {
                e.Cancel = true;
            }
        }
    }
}