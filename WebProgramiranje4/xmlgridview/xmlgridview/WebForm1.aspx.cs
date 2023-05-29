using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace xmlgridview
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static List<Knjiga> lista_knjiga;
        protected void Page_Load(object sender, EventArgs e)
        {
            lista_knjiga = new List<Knjiga>();
        }

        protected void btdodaj_Click(object sender, EventArgs e)
        {
            lista_knjiga.Add(new Knjiga(tbisbn.Text, tbnaslov.Text, int.Parse(tbstanje.Text), int.Parse(tbstanje.Text)));
            tbisbn.Text = tbnaslov.Text = tbstanje.Text = tbcitano.Text = "";
            tbisbn.Focus();
        }

        protected void btkraj_Click(object sender, EventArgs e)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.NewLineOnAttributes = true;
            XmlWriter writer = XmlWriter.Create(Server.MapPath("XMLFile1.xml"), settings);
            writer.WriteStartDocument();
            writer.WriteStartElement("Class1");

            foreach (Knjiga k in lista_knjiga)
            {
                writer.WriteStartElement("knjiga");
                writer.WriteStartAttribute("isbn");
                writer.WriteValue(k.Isbn);
                writer.WriteEndAttribute();
                writer.WriteStartElement("Naslov");
                writer.WriteValue(k.Naslov);
                writer.WriteEndElement();
                writer.WriteStartElement("Stanje");
                writer.WriteValue(k.Stanje);
                writer.WriteEndElement();
                writer.WriteStartElement("Citano");
                writer.WriteValue(k.Citano);
                writer.WriteEndElement();

            }

            writer.WriteEndElement();
            writer.Close();
            writer.Flush();

            DataSet ds = new DataSet();
            ds.ReadXml(Request.PhysicalApplicationPath + "XMLFile1.xml");
            gvknjige.DataSource = ds;
            gvknjige.AllowSorting = true;
            gvknjige.DataBind();
        }

        protected void gvknjige_Sorting(object sender, GridViewSortEventArgs e)
        {
            //zabranjuje sortiranje po ovim poljima naredni kod
            if (e.SortExpression == "ISBN" || e.SortExpression == "naslov" ||e.SortExpression =="stanje")
            {
                e.Cancel = true;
            }
        }

        protected void gvknjige_Sorted(object sender, EventArgs e)
        {
            string srb, pom = gvknjige.SortDirection.ToString();
            if (pom =="Ascending") srb = "rastucem";
            else srb = "opadajucem";
        }
    }
}