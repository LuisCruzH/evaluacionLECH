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
        // GET: Lista
        public ActionResult Index()
        {
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
    }
}