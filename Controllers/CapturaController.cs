using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using evaluacionLECH.Models;

namespace evaluacionLECH.Controllers
{
    public class CapturaController : Controller
    {
        public ActionResult Index()
        {
            /*List<SelectListItem> tDocumento = new List<SelectListItem>() {
                new SelectListItem {
                    Text = "ASP.NET MVC", Value = "1"
                },
                new SelectListItem {
                    Text = "ASP.NET WEB API", Value = "2"
                },
                new SelectListItem {
                    Text = "ENTITY FRAMEWORK", Value = "3"
                }
            };*/


            using (var bd = new evaluacionBDEntities())
            {

            }
            return View();
        }
    }
}