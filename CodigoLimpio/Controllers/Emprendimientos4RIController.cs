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
    public class Emprendimientos4RIController : Controller
    {
        private CodigoMVCEntities db = new CodigoMVCEntities();

        // GET: Emprendimientos4RI
        public ActionResult Index()
        {
            var emprendimientos4RI = db.Emprendimientos4RI.Include(e => e.Emprendimientos).Include(e => e.Herramientas4RI);
            return View(emprendimientos4RI.ToList());
        }

        // GET: Emprendimientos4RI/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emprendimientos4RI emprendimientos4RI = db.Emprendimientos4RI.Find(id);
            if (emprendimientos4RI == null)
            {
                return HttpNotFound();
            }
            return View(emprendimientos4RI);
        }

        // GET: Emprendimientos4RI/Create
        public ActionResult Create()
        {
            ViewBag.IdEmprendimientos = new SelectList(db.Emprendimientos, "IdEmprendimientos", "NombreEmprendimiento");
            ViewBag.IdHerramientas4RI = new SelectList(db.Herramientas4RI, "IdHerramientas4RI", "NombreHerramientas4RI");
            return View();
        }

        // POST: Emprendimientos4RI/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdEmprendimientos4RI,IdHerramientas4RI,IdEmprendimientos")] Emprendimientos4RI emprendimientos4RI)
        {
            if (ModelState.IsValid)
            {
                db.Emprendimientos4RI.Add(emprendimientos4RI);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdEmprendimientos = new SelectList(db.Emprendimientos, "IdEmprendimientos", "NombreEmprendimiento", emprendimientos4RI.IdEmprendimientos);
            ViewBag.IdHerramientas4RI = new SelectList(db.Herramientas4RI, "IdHerramientas4RI", "NombreHerramientas4RI", emprendimientos4RI.IdHerramientas4RI);
            return View(emprendimientos4RI);
        }

        // GET: Emprendimientos4RI/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emprendimientos4RI emprendimientos4RI = db.Emprendimientos4RI.Find(id);
            if (emprendimientos4RI == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdEmprendimientos = new SelectList(db.Emprendimientos, "IdEmprendimientos", "NombreEmprendimiento", emprendimientos4RI.IdEmprendimientos);
            ViewBag.IdHerramientas4RI = new SelectList(db.Herramientas4RI, "IdHerramientas4RI", "NombreHerramientas4RI", emprendimientos4RI.IdHerramientas4RI);
            return View(emprendimientos4RI);
        }

        // POST: Emprendimientos4RI/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdEmprendimientos4RI,IdHerramientas4RI,IdEmprendimientos")] Emprendimientos4RI emprendimientos4RI)
        {
            if (ModelState.IsValid)
            {
                db.Entry(emprendimientos4RI).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdEmprendimientos = new SelectList(db.Emprendimientos, "IdEmprendimientos", "NombreEmprendimiento", emprendimientos4RI.IdEmprendimientos);
            ViewBag.IdHerramientas4RI = new SelectList(db.Herramientas4RI, "IdHerramientas4RI", "NombreHerramientas4RI", emprendimientos4RI.IdHerramientas4RI);
            return View(emprendimientos4RI);
        }

        // GET: Emprendimientos4RI/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emprendimientos4RI emprendimientos4RI = db.Emprendimientos4RI.Find(id);
            if (emprendimientos4RI == null)
            {
                return HttpNotFound();
            }
            return View(emprendimientos4RI);
        }

        // POST: Emprendimientos4RI/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Emprendimientos4RI emprendimientos4RI = db.Emprendimientos4RI.Find(id);
            db.Emprendimientos4RI.Remove(emprendimientos4RI);
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
