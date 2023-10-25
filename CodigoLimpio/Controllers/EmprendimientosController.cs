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
    public class EmprendimientosController : Controller
    {
        private CodigoMVCEntities db = new CodigoMVCEntities();

        // GET: Emprendimientos
        public ActionResult Index()
        {
            return View(db.Emprendimientos.ToList());
        }

        // GET: Emprendimientos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emprendimientos emprendimientos = db.Emprendimientos.Find(id);
            if (emprendimientos == null)
            {
                return HttpNotFound();
            }
            return View(emprendimientos);
        }

        // GET: Emprendimientos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Emprendimientos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdEmprendimientos,NombreEmprendimiento,InversionRequerida,IngresosProyectados,InversionInfraestructura")] Emprendimientos emprendimientos)
        {
            if (ModelState.IsValid)
            {
                db.Emprendimientos.Add(emprendimientos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(emprendimientos);
        }

        // GET: Emprendimientos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emprendimientos emprendimientos = db.Emprendimientos.Find(id);
            if (emprendimientos == null)
            {
                return HttpNotFound();
            }
            return View(emprendimientos);
        }

        // POST: Emprendimientos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdEmprendimientos,NombreEmprendimiento,InversionRequerida,IngresosProyectados,InversionInfraestructura")] Emprendimientos emprendimientos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(emprendimientos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(emprendimientos);
        }

        // GET: Emprendimientos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Emprendimientos emprendimientos = db.Emprendimientos.Find(id);
            if (emprendimientos == null)
            {
                return HttpNotFound();
            }
            return View(emprendimientos);
        }

        // POST: Emprendimientos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Emprendimientos emprendimientos = db.Emprendimientos.Find(id);
            db.Emprendimientos.Remove(emprendimientos);
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

        public ActionResult MayorEmprendimiento()
        {
            // Consulta para encontrar el emprendimiento con los mayores ingresos en los primeros tres años.
            var MayorEmprendimiento = db.Emprendimientos.ToList();

            return View(MayorEmprendimiento);
        }


    }
}
