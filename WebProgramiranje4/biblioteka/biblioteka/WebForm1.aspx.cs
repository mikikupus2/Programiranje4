using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Data;

namespace biblioteka
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public class knjiga
        {
            public string isbn;
            public string naslov;
            public int stanje;
            public int citano;

            public knjiga(string isbn, string naslov, int stanje, int citano)
            {
                this.isbn = isbn;
                this.naslov = naslov;
                this.stanje = stanje;
                this.citano = citano;
            }
        }
        static List<knjiga> knjige = new List<knjiga>();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        private void bindgv()
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("biblioteka.xml"));
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }
        protected void Btdodaj_Click(object sender, EventArgs e)
        {
            knjige.Add(new knjiga(Tbisbn.Text, Tbnaslov.Text, Convert.ToInt32(Tbstanje.Text),
                Convert.ToInt32(Tbcitano.Text)));
            Tbisbn.Text = Tbnaslov.Text=Tbstanje.Text=Tbcitano.Text = String.Empty;
            Tbisbn.Focus();
        }

        protected void Btkraj_Click(object sender, EventArgs e)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.NewLineOnAttributes = true;
            XmlWriter writer = XmlWriter.Create(Server.MapPath("biblioteka.xml"), settings);
            writer.WriteStartDocument();
            writer.WriteStartElement("biblioteka");

            foreach (knjiga knjiga1 in knjige)
            {
                writer.WriteStartElement("knjiga");
                writer.WriteAttributeString("isbn", knjiga1.isbn);
                    writer.WriteStartElement("naslov");
                    writer.WriteValue(knjiga1.naslov);
                    writer.WriteEndElement();
                    writer.WriteStartElement("stanje");
                    writer.WriteValue(knjiga1.stanje);
                    writer.WriteEndElement();
                    writer.WriteStartElement("citano");
                    writer.WriteValue(knjiga1.citano);
                    writer.WriteEndElement();
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.Close();
            //writer.Flush();
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("biblioteka.xml"));
            GridView1.DataSource = ds.Tables[0];
            string sortExp = "citano";/*vrednost polja po kome se vrsi sortiranje*/
            string direction = string.Empty;
          
            SortDir = SortDirection.Descending;
            direction = " DESC";
       
            ds.Tables[0].DefaultView.Sort = sortExp + direction;//ds.Tables[0].DefaultView.Sort ="citano DESC"
            GridView1.DataBind();
        }

        protected void Btprikazi_Click(object sender, EventArgs e)
        {
            Response.Redirect("biblioteka.xml");
        }
        public SortDirection SortDir
        {
            get
            {
               if (ViewState["SortDir"] == null)
                    ViewState["SortDir"] = SortDirection.Descending;
                return (SortDirection)ViewState["SortDir"];
            }
            set
            {
                ViewState["SortDir"] = value;
            }
        }
        protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
        {
            string sortExp = e.SortExpression;
            string direction = string.Empty;
            //if (SortDir == SortDirection.Descending)
            //{
                SortDir = SortDirection.Descending;
                direction = " DESC";
            //}
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("biblioteka.xml"));
            GridView1.DataSource = ds.Tables[0];
            ds.Tables[0].DefaultView.Sort = sortExp + direction;
            GridView1.DataBind();
        }
    }
}