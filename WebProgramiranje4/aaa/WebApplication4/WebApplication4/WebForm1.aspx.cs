using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Data;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static List<Knjiga> biblioteka = new List<Knjiga>();
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        void bindgv()
        {

            DataSet ds = new DataSet();
            ds.ReadXml(Request.PhysicalApplicationPath + "XMLFile1.xml");
            GridView1.DataSource = ds;
            GridView1.AllowSorting = true;
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
        protected void btdodaj_Click(object sender, EventArgs e)
        {
            biblioteka.Add(new Knjiga(tbisbn.Text, tbnaslov.Text, int.Parse(tbstanje.Text), int.Parse(tbcitano.Text)));
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
            writer.WriteStartElement("Biblioteka");

            foreach (Knjiga k in biblioteka)
            {
                writer.WriteStartElement("Knjiga");
                writer.WriteStartAttribute("ISBN");
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
                writer.WriteEndElement();
            }

            writer.WriteEndElement();
            writer.Close();
            writer.Flush();
            bindgv();
           
        }

        protected void GridView1_Sorted(object sender, EventArgs e)
        {

        }

        protected void btxml_Click(object sender, EventArgs e)
        {
            Response.Redirect("XMLFile1.xml");
        }

        protected void GridView1_Sorting(object sender, GridViewSortEventArgs e)
        {
            
        }
    }
}