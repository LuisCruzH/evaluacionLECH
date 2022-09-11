using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using evaluacionLECH.Models;

namespace evaluacionLECH.Controllers
{
    public class CapturaController : Controller
    {
        #region ViewBag
        List<SelectListItem> listArchivos = new List<SelectListItem>()
            {
            new SelectListItem {
                    Text = "-Seleccione-", Value = "0"
                },
                new SelectListItem {
                    Text = "PDF", Value = "PDF"
                },
                new SelectListItem {
                    Text = "Docx", Value = "Docx"
                },
                new SelectListItem {
                    Text = "jpeg", Value = "jpeg"
                }
            };
        #endregion
        public ActionResult Index()
        {
            ViewBag.listArchivos = listArchivos;
            return View();
        }
        [HttpPost]
        public ActionResult Index(CapturaCLS oCapturaCLS, HttpPostedFileBase[] docs)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.listArchivos = listArchivos;
                return View(oCapturaCLS);
            }
            else
            {
                using (var bd = new evaluacionBDEntities())
                {
                    prospecto oProspecto = new prospecto();
                    if (docs != null)
                    {
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


                        List<string> files = new List<string>();
                        foreach (var doc in docs)
                        {
                            documentos oDocumento = new documentos();
                            doc.SaveAs(Server.MapPath("~/Content/Documents/" + oProspecto.id_prospecto +" " +doc.FileName));
                            files.Add(doc.FileName);

                            oDocumento.tipo_documento = oCapturaCLS.tipoDocumento;
                            oDocumento.documento = doc.FileName;
                            oDocumento.id_prospecto = oProspecto.id_prospecto;
                            bd.documentos.Add(oDocumento);
                            bd.SaveChanges();
                        }
                        oCapturaCLS.documentoList = files;
                    }                    
                }
            }
            return RedirectToAction("Index", "Lista");
        }
    }
}