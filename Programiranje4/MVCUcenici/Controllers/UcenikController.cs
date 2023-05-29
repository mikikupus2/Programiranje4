using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCUcenici.Models;

namespace MVCUcenici.Controllers
{
    public class UcenikController : Controller
    {
        private MVCUcenikEntities db = new MVCUcenikEntities();

        // GET: Ucenik
        public ActionResult Index()
        {
            return View(db.Uceniks.ToList());
        }

        // GET: Ucenik/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ucenik ucenik = db.Uceniks.Find(id);
            if (ucenik == null)
            {
                return HttpNotFound();
            }
            return View(ucenik);
        }

        // GET: Ucenik/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ucenik/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Prezime,Ime,Pol,Email,Razred_i_Odeljenje,Prosecna_Ocena")] Ucenik ucenik)
        {
            if (ModelState.IsValid)
            {
                db.Uceniks.Add(ucenik);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ucenik);
        }

        // GET: Ucenik/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ucenik ucenik = db.Uceniks.Find(id);
            if (ucenik == null)
            {
                return HttpNotFound();
            }
            return View(ucenik);
        }

        // POST: Ucenik/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Prezime,Ime,Pol,Email,Razred_i_Odeljenje,Prosecna_Ocena")] Ucenik ucenik)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ucenik).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ucenik);
        }

        // GET: Ucenik/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ucenik ucenik = db.Uceniks.Find(id);
            if (ucenik == null)
            {
                return HttpNotFound();
            }
            return View(ucenik);
        }

        // POST: Ucenik/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ucenik ucenik = db.Uceniks.Find(id);
            db.Uceniks.Remove(ucenik);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
