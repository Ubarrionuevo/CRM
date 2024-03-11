using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebadmiClient;
using WebadmiClient.Models;

namespace WebadmiClient.Controllers
{
    public class MovimientoCuentas1Controller : Controller
    {
        private ApDbContext db = new ApDbContext();

        // GET: MovimientoCuentas1
        public ActionResult Index()
        {
            if (Session["Usuario"] == null)
            {
                return RedirectToAction("Login", "Login");
            }



            return View(db.MovimientoCuenta.ToList());
        }

        // GET: MovimientoCuentas1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovimientoCuenta movimientoCuenta = db.MovimientoCuenta.Find(id);
            if (movimientoCuenta == null)
            {
                return HttpNotFound();
            }
            return View(movimientoCuenta);
        }

        // GET: MovimientoCuentas1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MovimientoCuentas1/Create
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Fhmovimiento,Importe,Descripcion,Activo")] MovimientoCuenta movimientoCuenta)
        {
            if (ModelState.IsValid)
            {
                db.MovimientoCuenta.Add(movimientoCuenta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movimientoCuenta);
        }

        // GET: MovimientoCuentas1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovimientoCuenta movimientoCuenta = db.MovimientoCuenta.Find(id);
            if (movimientoCuenta == null)
            {
                return HttpNotFound();
            }
            return View(movimientoCuenta);
        }

        // POST: MovimientoCuentas1/Edit/5
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Fhmovimiento,Importe,Descripcion,Activo")] MovimientoCuenta movimientoCuenta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movimientoCuenta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movimientoCuenta);
        }

        // GET: MovimientoCuentas1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovimientoCuenta movimientoCuenta = db.MovimientoCuenta.Find(id);
            if (movimientoCuenta == null)
            {
                return HttpNotFound();
            }
            return View(movimientoCuenta);
        }

        // POST: MovimientoCuentas1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MovimientoCuenta movimientoCuenta = db.MovimientoCuenta.Find(id);
            db.MovimientoCuenta.Remove(movimientoCuenta);
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
