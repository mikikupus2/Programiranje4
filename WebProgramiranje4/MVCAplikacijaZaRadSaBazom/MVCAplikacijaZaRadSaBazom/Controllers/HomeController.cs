using MVCAplikacijaZaRadSaBazom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

namespace MVCAplikacijaZaRadSaBazom.Controllers
{
    public class HomeController : Controller
    {
        public static List<Ucenik> ucenici = new List<Ucenik>();
        private readonly 
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Edit(int id)
        {
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