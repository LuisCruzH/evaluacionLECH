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
            using (var bd=new evaluacionBDEntities())
            {

            }
            return View();
        }
    }
}