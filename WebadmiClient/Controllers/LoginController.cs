using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebadmiClient.Models;

namespace WebadmiClient.Controllers
{
    

    public class LoginController : Controller
    {
       
        [HttpGet]
        public ActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Login(string NombreUsuario, string Contraseña)
        {
            // Verificar las credenciales del usuario
            if (NombreUsuario == "usuario" && Contraseña == "contrasena")
            {
                // Usuario autenticado, generar un token JWT
                string token = JwtUtils.GenerateToken(NombreUsuario);
                
                // Agregar el token a las cookies o enviarlo en la respuesta (según tus necesidades)

                // Redirigir a la página principal u otra página protegida

                return RedirectToAction("Index", "Home");
                
            }
            else
            {
                // Credenciales incorrectas, mostrar un mensaje de error
                ViewBag.ErrorMessage = "Credenciales incorrectas.";
                return View();
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

