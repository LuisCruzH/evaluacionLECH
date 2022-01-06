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
            return View();
        }
        [HttpPost]
        public ActionResult Agregar(CapturaCLS oCapturaCLS)
        {
            if (!ModelState.IsValid)
            {
                return View(oCapturaCLS);
            }
            else
            {
                
                using (var bd = new evaluacionBDEntities())
                {
                    prospecto oProspecto = new prospecto();
                    oProspecto.nombre = oCapturaCLS.nombreProspecto;
                    oProspecto.a_paterno = oCapturaCLS.aPaternoProspecto;
                    oProspecto.a_materno = oCapturaCLS.aMaternoProspecto;
                    oProspecto.rfc = oCapturaCLS.rfcProspecto;
                    oProspecto.telefono = oCapturaCLS.telefonoProspecto;
                    oProspecto.estatus = 1;
                    bd.prospecto.Add(oProspecto);
                    bd.SaveChanges();

                    datos_prospecto oDatosPros = new datos_prospecto();
                    oDatosPros.calle = oCapturaCLS.calle;
                    oDatosPros.numero = oCapturaCLS.numero;
                    oDatosPros.colonia = oCapturaCLS.colonia;
                    oDatosPros.codigo_postal = oCapturaCLS.codigoPostal;
                    oDatosPros.id_prospecto = oProspecto.id_prospecto;
                    bd.datos_prospecto.Add(oDatosPros);
                    bd.SaveChanges();
                }
            }
            return RedirectToAction("Index","Lista");
        }

        //[HttpPost]
        //public ActionResult Upload(IEnumerable<HttpPostedFileBase> files)
        //{
        //    foreach (var file in files)
        //    {
        //        file.SaveAs(Server.MapPath("~/Update/" + file.FileName));
        //    }

        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Upload()
        //{
        //    foreach (var file in Request.Files)
        //    {
        //        file.SaveAs(Server.MapPath("~/Update/" + file.FileName));
        //    }

        //    return View();
        //}
    }
}