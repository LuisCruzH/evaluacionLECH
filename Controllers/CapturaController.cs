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
            
            List<CapturaCLS> listaCaptura = null;
            using (var bd = new evaluacionBDEntities())
            {
                listaCaptura = (from captura in bd.prospecto
                                select new CapturaCLS
                                {
                                    nombreProspecto = captura.nombre,
                                    aPaternoProspecto = captura.a_paterno,
                                    aMaternoProspecto = captura.a_materno,
                                    estatusProspecto = captura.estatus.Value
                                }
                                ).ToList();
            }
            return View(listaCaptura);
        }
        public ActionResult Agregar()
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
            return RedirectToAction("Index");
        }
    }
}