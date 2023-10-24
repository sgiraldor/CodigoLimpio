using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CodigoLimpio.Models;

namespace CodigoLimpio.Controllers
{
    public class Herramientas4RIController : Controller
    {
        private CodigoMVCEntities db = new CodigoMVCEntities();

        // GET: Herramientas4RI
        public ActionResult Index()
        {
            return View(db.Herramientas4RI.ToList());
        }

        // GET: Herramientas4RI/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Herramientas4RI herramientas4RI = db.Herramientas4RI.Find(id);
            if (herramientas4RI == null)
            {
                return HttpNotFound();
            }
            return View(herramientas4RI);
        }

        // GET: Herramientas4RI/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Herramientas4RI/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdHerramientas4RI,NombreHerramientas4RI")] Herramientas4RI herramientas4RI)
        {
            if (ModelState.IsValid)
            {
                db.Herramientas4RI.Add(herramientas4RI);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(herramientas4RI);
        }

        // GET: Herramientas4RI/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Herramientas4RI herramientas4RI = db.Herramientas4RI.Find(id);
            if (herramientas4RI == null)
            {
                return HttpNotFound();
            }
            return View(herramientas4RI);
        }

        // POST: Herramientas4RI/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdHerramientas4RI,NombreHerramientas4RI")] Herramientas4RI herramientas4RI)
        {
            if (ModelState.IsValid)
            {
                db.Entry(herramientas4RI).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(herramientas4RI);
        }

        // GET: Herramientas4RI/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Herramientas4RI herramientas4RI = db.Herramientas4RI.Find(id);
            if (herramientas4RI == null)
            {
                return HttpNotFound();
            }
            return View(herramientas4RI);
        }

        // POST: Herramientas4RI/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Herramientas4RI herramientas4RI = db.Herramientas4RI.Find(id);
            db.Herramientas4RI.Remove(herramientas4RI);
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
