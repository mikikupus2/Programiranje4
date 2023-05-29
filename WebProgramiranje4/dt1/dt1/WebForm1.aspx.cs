using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace dt1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private DataTable temperaturekreiraj()
        {
            DataTable temp = new DataTable();
            DataColumn rb = new DataColumn("RB");
            rb.DataType = typeof(int);
            rb.AllowDBNull = false;
            temp.Columns.Add(rb);

            DataColumn imegrada = new DataColumn("IME_GRADA");
            imegrada.DataType = typeof(string);
            imegrada.MaxLength = 25;
            imegrada.AllowDBNull = false;
            temp.Columns.Add(imegrada);

            DataColumn t = new DataColumn("TEMPERATURA");
            t.DataType = typeof(float);
            t.AllowDBNull = false;
            temp.Columns.Add(t);

            temp.PrimaryKey = new DataColumn[] { rb };
            temp.LoadDataRow(new object[] { 1, "Smederevo", 17.2 }, LoadOption.OverwriteChanges);
            temp.LoadDataRow(new object[] { 2, "Beograd", 16.5 }, LoadOption.OverwriteChanges);
            temp.LoadDataRow(new object[] { 3, "Kovin", 18.2}, LoadOption.OverwriteChanges);

            DataRow novi = temp.NewRow();
            novi["RB"] = 4;
            novi["IME_GRADA"] = "Pozarevac";
            novi["TEMPERATURA"] = 11.2;

            temp.Rows.Add(novi);

            return temp;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView gv = new GridView();
            gv.Style.Add("position", "absolute");
            gv.Style.Add("left", "100px");
            gv.Style.Add("top", "50px");
            gv.EnableViewState = false;
            form1.Controls.Add(gv);
            gv.DataSource = temperaturekreiraj();
            gv.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DataSet podaci = new DataSet("podaci");
            DataTable temp = temperaturekreiraj();
            podaci.Tables.Add(temp);
            podaci.WriteXml(Server.MapPath("temp.xml"));
            Response.Redirect("temp.xml");
        }
    }
}