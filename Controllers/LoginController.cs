using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using evaluacionLECH.Models;

namespace evaluacionLECH.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public string Login(LoginCLS oUser)
        {
            string mensaje = "";          
            if (!ModelState.IsValid)
            {
                var query = (from state in ModelState.Values
                             from error in state.Errors
                             select error.ErrorMessage).ToList();
                mensaje += "<ul class = 'list-group'>";
                foreach (var item in query)
                {
                    mensaje += "<li class='list-gropu-item'>" + item + "</li>";
                }
                mensaje += "</ul>";
            }
            else
            {
                string usuario = oUser.username;
                string pass = oUser.password;                
                using (var bd = new evaluacionBDEntities())
                {
                    int numeroVeces = bd.usuario.Where(p=>p.usuario1 == usuario && p.contrasena == pass).Count();
                    mensaje = numeroVeces.ToString();
                    if(mensaje== "0") mensaje = "Usuario o contrasena incorrecto";
                }
            }
            return mensaje;
        }
    }
}