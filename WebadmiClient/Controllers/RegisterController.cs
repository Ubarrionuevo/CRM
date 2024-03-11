using System.Data.Entity;
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web.Mvc;
using System.Web.Security;
using WebadmiClient.Models;


namespace WebadmiClient.Controllers
{
    using System;
    using System.Web.Mvc;

    public class RegisterController : Controller
    {
        private readonly ApDbContext _context;

        public RegisterController()
        {
            _context = new ApDbContext();
        }

        // GET: Registro
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(Register usuario)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Register.Add(usuario);
                    _context.SaveChanges();

                    return RedirectToAction("Index", "Login"); // Redirigir al usuario a la página de inicio de sesión
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Error al registrar usuario: " + ex.Message);
                }
            }

            return View(usuario);
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            base.Dispose(disposing);
        }
    }


}

