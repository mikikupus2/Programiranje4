using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADO1
{
    public partial class forma1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BindGridView()
        {
            OleDbConnection con = new OleDbConnection(SqlDataSource1.ConnectionString);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT NAZIV, SEDITE FROM BANKA",con);
            OleDbDataAdapter a

            
        }
    }
}