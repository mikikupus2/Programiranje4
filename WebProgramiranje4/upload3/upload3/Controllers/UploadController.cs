using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using upload3.Models;

namespace upload3.Controllers
{
    public class UploadController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public static string _path = "";
        public static string _raspored = "";
        [HttpGet]
        public ActionResult UploadFile()
        {
            return View();
        }
        public ActionResult Raspored()
        {
            List<Raspored> raspored = new List<Raspored>();
            if (System.IO.File.Exists(_path))
            {
                XmlDocument doc = new XmlDocument();

                ViewBag.Message = _path;
                string fajl = Path.Combine("~/UploadedFiles", _raspored);
                doc.Load(Server.MapPath(fajl));
                
                foreach (XmlNode node in doc.SelectNodes("Rasporednedelja/Raspored"))
                    raspored.Add(new Raspored(int.Parse(node["Rbr"].InnerText), node["DanUNedelji"].InnerText, node["Predmet"].InnerText)); 
            }
            else
                ViewBag.Message = "nema rasporeda";
            return View(raspored);
        }
        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase file)
        {
            try
            {
                if (file.ContentLength > 0)
                {
                    string _FileName = Path.GetFileName(file.FileName);
                    _raspored = _FileName;
                    _path = Path.Combine(Server.MapPath("/UploadedFiles"), _FileName);
                    file.SaveAs(_path);
                }
                ViewBag.Message = "Fajl " + _path + " je uspesno ucitan";
                return View();
            }
            catch
            {
                ViewBag.Message = "Fajl nije uspesno ucitan!";
                return View();
            }
        }
    }

}