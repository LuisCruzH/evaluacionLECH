using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using evaluacionLECH.Helpers;

namespace evaluacionLECH.Models
{
    public class CapturaCLS
    {
        /*Prospecto*/
        [Display(Name ="ID")]
        public int iidProspecto { get; set; }
        [Display(Name = "Nombre")]
        [StringLength(25, ErrorMessage = "Longitud Maxima de 25")]
        [Required]
        public string nombreProspecto { get; set; }
        [Display(Name = "Apellido Paterno")]
        [StringLength(15, ErrorMessage = "Longitud Maxima de 15")]
        [Required]
        public string aPaternoProspecto { get; set; }
        [Display(Name = "Apellido Materno")]
        [StringLength(15, ErrorMessage = "Longitud Maxima de 15")]
        public string aMaternoProspecto { get; set; }
        [Display(Name = "RFC")]
        [StringLength(13, ErrorMessage = "Longitud Maxima de 13")]
        [Required]
        public string rfcProspecto { get; set; }
        [Display(Name = "Telefono")]
        [StringLength(13, ErrorMessage = "Longitud Maxima de 13")]
        [Required]
        public string telefonoProspecto { get; set; }
        [Display (Name ="Estatus")]
        public int estatusProspecto { get; set; }

        /*Datos de Prospecto*/
        [Display(Name = "Calle")]
        [Required]
        public string calle { get; set; }
        [Display(Name = "Numero")]
        [Required]
        public string numero { get; set; }
        [Display(Name = "Colonia")]
        [Required]
        public string colonia { get; set; }
        [Display(Name = "Codigo Postal")]
        [Required]
        public int codigoPostal { get; set; }

        public ViewDataUploadFilesResult[] Files { get; set; }
    }
}