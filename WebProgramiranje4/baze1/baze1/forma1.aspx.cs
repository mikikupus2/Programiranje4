using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace baze1
{
    public partial class forma1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Radi(object sender, EventArgs e)
        {
            SqlDataSource1.InsertParameters["NAZIV"].DefaultValue = 
                ((TextBox)GridView1.FooterRow.FindControl("txtNaziv")).Text;
            SqlDataSource1.InsertParameters["SEDIŠTE"].DefaultValue =
                ((TextBox)GridView1.FooterRow.FindControl("txtSediste")).Text;
            SqlDataSource1.InsertParameters["BRZAPOSLENIH"].DefaultValue =
                (TextBox)GridView1.FooterRow.FindControl("txtZaposleni")).Text;
            SqlDataSource1.Insert();
        }
    }
}