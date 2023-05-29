using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.IO;

namespace kreiranje_xml_fajlova
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static ucenik[] ucenici = new ucenik[30];       
        static int bruc = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btunos_Click(object sender, EventArgs e)
        {
            ucenici[bruc] = new ucenik(int.Parse(Tbid.Text), Tbime.Text,Tbprezime.Text,double.Parse(Tbprosek.Text));
            string pom = Tbid.Text + " " + Tbime.Text + " " + Tbprezime.Text + " " + Tbprosek.Text + "\n";
            TbNiz.Text += pom;
            bruc++;            
            Tbime.Text = Tbid.Text = Tbprezime.Text = Tbprosek.Text = String.Empty;
            Tbid.Focus();
        }

        protected void Btkraj_Click(object sender, EventArgs e)
        {
            //XmlDocument XmlDocObj = new XmlDocument();
            //XmlDocObj.CreateXmlDeclaration("1.0", null, null);
            string xmlfile = Path.Combine(@"D:\Mihajlo Randjelovic IV-1\kreiranje_xml_fajlova", "ucenici.xml");
            FileStream xmlfileStream = File.Create(xmlfile);
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;
            settings.NewLineOnAttributes = true;
            using (XmlWriter writer = XmlWriter.Create(xmlfile,settings))
            {               
                writer.WriteStartDocument();
                writer.WriteStartElement("ucenici");
                foreach (ucenik uc in ucenici)
                {
                    writer.WriteStartElement("ucenik");
                    writer.WriteElementString("ID", uc.Id.ToString());
                    writer.WriteElementString("Ime", uc.Ime);
                    writer.WriteElementString("Prezime", uc.Prezime);
                    writer.WriteElementString("Prosek", uc.Prosek.ToString());
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();                
                //XmlDocObj.Save(Server.MapPath("ucenici.xml"));
                Response.Redirect(@"D:\Mihajlo Randjelovic IV-1\kreiranje_xml_fajlova\ucenici.xml");
                writer.Flush();
                writer.Close();
            }
        }
    }
}