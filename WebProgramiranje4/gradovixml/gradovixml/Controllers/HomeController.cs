using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml; /*moramo da dodamo jer radimo sa xml fajlom*/
using gradovixml.Models; /*moramo dodati naziv_projekta.Models*/
namespace gradovixml.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            XmlDocument doc = new XmlDocument();
            List<grad> gradovi = new List<grad>();
            /*grad je naziv klase koju smo definisali u folderu Models*/
            doc.Load(Server.MapPath("/App_Data/gradovi.xml"));
            foreach (XmlNode node in doc.SelectNodes("Gradovi/Grad"))
            {
                gradovi.Add(new grad
                {
                    id = node["GradID"].InnerText,
                    ime = node["GradIme"].InnerText,
                    pbr = node["Postbroj"].InnerText
                });
            }
            return View(gradovi);
        }

        public ActionResult About()
        {
            ViewBag.Message = "O aplikaciji...";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "O autoru";

            return View();
        }

        public ActionResult Skola()
        {
            ViewBag.Message = "Podaci o skoli";

            return View();
        }
    }
}