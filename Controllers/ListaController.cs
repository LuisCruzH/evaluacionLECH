using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using evaluacionLECH.Models;

namespace evaluacionLECH.Controllers
{
    public class ListaController : Controller
    {
        #region ViewBag
        List<SelectListItem> listEstatus = new List<SelectListItem>()
            {
                new SelectListItem {
                    Text = "Enviado", Value = "1"
                },
                new SelectListItem {
                    Text = "Autorizado", Value = "2"
                },
                new SelectListItem {
                    Text = "Rechazado", Value = "3"
                }
            };
        #endregion
        // GET: Lista
        public ActionResult Index()
        {
            ViewBag.listEstatus = listEstatus;
            List<CapturaCLS> listaCaptura = null;
            using (var bd = new evaluacionBDEntities())
            {
                listaCaptura = (from captura in bd.prospecto
                                select new CapturaCLS
                                {
                                    iidProspecto = captura.id_prospecto,
                                    nombreProspecto = captura.nombre,
                                    aPaternoProspecto = captura.a_paterno,
                                    aMaternoProspecto = captura.a_materno,
                                    estatusProspecto = captura.estatus.Value
                                }
                                ).ToList();
            }
            return View(listaCaptura);
        }
        public string editarlo(CapturaCLS oCapturaCLS, int titulo)
        {
            string rpta = "";
            using (var bd = new evaluacionBDEntities())
            {
                prospecto oProspecto = bd.prospecto.Where(p => p.id_prospecto.Equals(titulo)).First();
                oProspecto.estatus = oCapturaCLS.estatusProspecto;
                oProspecto.observaciones = oCapturaCLS.observacionesProspecto;
                rpta = bd.SaveChanges().ToString();
            }
            return rpta;
        }
        public JsonResult recuperarDatos (int titulo)
        {
            CapturaCLS oCapturaCLS = new CapturaCLS();
            using (var bd = new evaluacionBDEntities())
            {
                prospecto oProspecto = bd.prospecto.Where(p => p.id_prospecto.Equals(titulo)).First();
                oCapturaCLS.estatusProspecto = oProspecto.estatus.Value;
                oCapturaCLS.observacionesProspecto = oProspecto.observaciones;
            }
            return Json(oCapturaCLS, JsonRequestBehavior.AllowGet);
        }
    }
}