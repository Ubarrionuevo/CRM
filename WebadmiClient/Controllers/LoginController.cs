using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebadmiClient.Models;

namespace WebadmiClient.Controllers
{
    

    public class LoginController : Controller
    {
        // GET: /Account/Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        public ActionResult Login(Login usuario)
        {
            if (usuario.NombreUsuario == "usuario" && usuario.Contraseña == "contraseña")
            {
                // Aquí podrías agregar la lógica para autenticar al usuario, como almacenar información en sesión
                return RedirectToAction("Index", "Home"); // Redirigir al usuario a la página de inicio
            }
            else
            {
                ModelState.AddModelError("", "Nombre de usuario o contraseña incorrectos.");
                return View(usuario);
            }
        }
        [HttpGet]
        public ActionResult Logout()
        {
            // Aquí puedes agregar la lógica para cerrar la sesión del usuario
            // Por ejemplo:
            // Session.Clear(); // Limpiar todos los datos de sesión
            //Session.Abandon(); // Abandonar la sesión actual

            return RedirectToAction("Login", "Login"); // Redirigir a la página de inicio de sesión
        }
    }
}

