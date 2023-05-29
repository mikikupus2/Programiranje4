using MVCBiblioteka.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace MVCBiblioteka.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            XmlDocument doc = new XmlDocument();
            List<Knjiga> knjige = new List<Knjiga>();
            doc.Load(Server.MapPath("/App_Data/Knjige.xml"));
            foreach (XmlNode node in doc.SelectNodes("Knjige/Knjiga"))
            {
                knjige.Add(new Knjiga(int.Parse(node["KnjigaISBN"].InnerText), int.Parse(node["KnjigaStanje"].InnerText), int.Parse(node["KnjigaCitano"].InnerText), node["KnjigaNaziv"].InnerText));
            }
            for (int i = 0; i < knjige.Count(); i++)
            {
                for (int j = i + 1; j < knjige.Count(); j++)
                {
                    if (knjige[j].Citano > knjige[i].Citano)
                    {
                        Knjiga pomocna = knjige[j];
                        knjige[j] = knjige[i];
                        knjige[i] = pomocna;
                    }
                }
            }

            return View(knjige);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}