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
    public class Clientes1Controller : Controller
    {
        private ApDbContext db = new ApDbContext();

        // GET: Clientes1
        public ActionResult Index()
        {
            return View(db.ModelsClients.ToList());
        }

        // GET: Clientes1/Details/
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clientes clientes = db.ModelsClients.Find(id);
            if (clientes == null)
            {
                return HttpNotFound();
            }
            return View(clientes);
        }

        // GET: Clientes1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes1/Create
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre,Apellido,Identificacion,Saldo,Estado,Activo")] Clientes clientes)
        {
            if (ModelState.IsValid)
            {
                db.ModelsClients.Add(clientes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clientes);
        }

        // GET: Clientes1/Edit/
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clientes clientes = db.ModelsClients.Find(id);
            if (clientes == null)
            {
                return HttpNotFound();
            }
            return View(clientes);
        }

        // POST: Clientes1/Edit/5
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre,Apellido,Identificacion,Saldo,Estado,Activo")] Clientes clientes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clientes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clientes);
        }

        // GET: Clientes1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clientes clientes = db.ModelsClients.Find(id);
            if (clientes == null)
            {
                return HttpNotFound();
            }
            return View(clientes);
        }

        // POST: Clientes1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var cliente = db.ModelsClients.Find(id); // Buscar al cliente por su Id en la base de datos

            if (cliente == null)
            {
                return HttpNotFound(); // Manejar el caso donde el cliente no es encontrado
            }

            if (cliente.Saldo == 0 || cliente.Saldo == null) // Agregar condición para permitir eliminar clientes con saldo 0 o saldo nulo
            {
                db.ModelsClients.Remove(cliente); // Eliminar el cliente de la base de datos
                db.SaveChanges(); // Guardar los cambios en la base de datos
            }
            else
            {
                ViewBag.ErrorMessage = "No se puede dar de baja al cliente porque tiene un saldo pendiente."; // Mensaje de error
                return View("Error"); // Renderizar una vista de error o manejarlo de acuerdo a tu lógica
            }

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
