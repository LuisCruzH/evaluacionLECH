using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using evaluacionLECH.Models;

namespace evaluacionLECH.Controllers
{
    public class EvaluaController : Controller
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
        // GET: Evalua
        public ActionResult Index(int id)
        {
          
            ViewBag.listEstatus = listEstatus;

            CapturaCLS oCapturaCLS = new CapturaCLS();
            using (var bd = new evaluacionBDEntities())
            {
                prospecto oProspecto = bd.prospecto.Where(p => p.id_prospecto.Equals(id)).First();
                datos_prospecto oDatos_Prospecto = bd.datos_prospecto.Where(p => p.id_prospecto.Equals(id)).First();
                documentos oDocumentos = bd.documentos.Where(p => p.id_prospecto.Equals(id)).First();

                oCapturaCLS.iidProspecto = oProspecto.id_prospecto;
                oCapturaCLS.nombreProspecto = oProspecto.nombre;
                oCapturaCLS.aPaternoProspecto = oProspecto.a_paterno;
                oCapturaCLS.aMaternoProspecto = oProspecto.a_materno;
                oCapturaCLS.telefonoProspecto = oProspecto.telefono;
                oCapturaCLS.rfcProspecto = oProspecto.rfc;
                oCapturaCLS.observacionesProspecto = oProspecto.observaciones;
                oCapturaCLS.estatusProspecto = oProspecto.estatus.Value;
                oCapturaCLS.calle = oDatos_Prospecto.calle;
                oCapturaCLS.numero = oDatos_Prospecto.numero;
                oCapturaCLS.colonia = oDatos_Prospecto.colonia;
                oCapturaCLS.codigoPostal = oDatos_Prospecto.codigo_postal.Value;

                oCapturaCLS.colonia = oDocumentos.tipo_documento;
                oCapturaCLS.colonia = oDocumentos.documento;


            }
            return View(oCapturaCLS);
        }
    }
}