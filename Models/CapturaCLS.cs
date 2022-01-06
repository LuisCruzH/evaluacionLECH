using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace evaluacionLECH.Models
{
    public class CapturaCLS
    {
        /*Prospecto*/
        [Display(Name ="ID")]
        public int iidProspecto { get; set; }
        [Display(Name = "Nombre")]
        public string nombreProspecto { get; set; }
        [Display(Name = "Apellido Paterno")]
        public string aPaternoProspecto { get; set; }
        [Display(Name = "Apellido Materno")]
        public string aMaternoProspecto { get; set; }
        [Display(Name = "RFC")]
        public string rfcProspecto { get; set; }
        [Display(Name = "Telefono")]
        public string telefonoProspecto { get; set; }
        [Display (Name ="Estatus")]
        public int estatusProspecto { get; set; }
        [Display(Name ="Observaciones")]
        public string observacionesProspecto { get; set; }
        

        /*Datos de Prospecto*/
        [Display(Name = "Calle")]
        public string calle { get; set; }
        [Display(Name = "Numero")]
        public string numero { get; set; }
        [Display(Name = "Colonia")]
        public string colonia { get; set; }
        [Display(Name = "Codigo Postal")]
        public int codigoPostal { get; set; }

        /*Documentos*/
        public string tipoDocumento { get; set; }
        public string nombreDocumento { get; set; }
    }
}