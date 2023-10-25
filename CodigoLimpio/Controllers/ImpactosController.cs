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
    public class ImpactosController : Controller
    {
        private CodigoMVCEntities db = new CodigoMVCEntities();

        // GET: Impactos
        public ActionResult Index()
        {
            
            return View(db.Impactos.ToList());
        }


        public ActionResult DesarrolloSostenible()
        {

            int conteo = db.Impactos.Count(h => h.NombreImpacto.Contains("desarrollo sostenible"));
            return View(conteo);
        }




        // GET: Impactos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Impactos impactos = db.Impactos.Find(id);
            if (impactos == null)
            {
                return HttpNotFound();
            }
            return View(impactos);
        }

        // GET: Impactos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Impactos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdImpactos,NombreImpacto,ImpactoDepartamento")] Impactos impactos)
        {
            if (ModelState.IsValid)
            {
                db.Impactos.Add(impactos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(impactos);
        }

        // GET: Impactos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Impactos impactos = db.Impactos.Find(id);
            if (impactos == null)
            {
                return HttpNotFound();
            }
            return View(impactos);
        }

        // POST: Impactos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdImpactos,NombreImpacto,ImpactoDepartamento")] Impactos impactos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(impactos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(impactos);
        }

        // GET: Impactos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Impactos impactos = db.Impactos.Find(id);
            if (impactos == null)
            {
                return HttpNotFound();
            }
            return View(impactos);
        }

        // POST: Impactos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Impactos impactos = db.Impactos.Find(id);
            db.Impactos.Remove(impactos);
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
