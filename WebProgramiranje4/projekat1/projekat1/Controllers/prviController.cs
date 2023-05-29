using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projekat1.Controllers
{
    public class prviController : Controller
    {
        // GET: prvi
        public string Index()
        {
            string pom = "Moja prva MVC aplikacija";
            return pom;
            //return View();
        }
    }
}