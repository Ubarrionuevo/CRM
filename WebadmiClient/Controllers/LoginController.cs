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
       
            // Otras acciones del controlador...

            [HttpPost]
            public ActionResult Login(Login usuario)
            {
                // Lógica para autenticar al usuario
                if (usuario.NombreUsuario == "usuario" && usuario.Contraseña == "contraseña")
                {
                    Session["Usuario"] = usuario.NombreUsuario;
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
            Session.Clear();
            Session.Abandon();

            return RedirectToAction("Login", "Login"); // Redirigir a la página de inicio de sesión
           
        }
    }
}

