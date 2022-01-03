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
            //List<CapturaCLS> listaCaptura = null;
            //using (var bd = new evaluacionBDEntities())
            //{
            //    listaCaptura = (from Prospecto in bd.prospecto
            //                    join dProspecto in bd.datos_prospecto
            //                    on Prospecto.id_prospecto equals dProspecto.id_prospecto
            //                    join Documentos in bd.documentos
            //                    on Prospecto.id_prospecto equals Documentos.id_prospecto
            //                    select new CapturaCLS
            //                    {
            //                        iidProspecto = Prospecto.id_prospecto,
            //                        nombreProspecto = Prospecto.nombre,
            //                        aPaternoProspecto = Prospecto.a_paterno,
            //                        aMaternoProspecto = Prospecto.a_materno,
            //                        rfcProspecto = Prospecto.rfc,
            //                        telefonoProspecto = Prospecto.telefono,

            //                        calle = dProspecto.calle,
            //                        numero = dProspecto.numero,
            //                        colonia = dProspecto.colonia,
            //                        codigoPostal = (int)dProspecto.codigo_postal

            //                    }).ToList();
            //}
            return View();
        }
        [HttpPost]
        public ActionResult Index(CapturaCLS oCapturaCLS)
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