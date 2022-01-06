using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace evaluacionLECH.Models
{
    public class CapturaCLS
    {
        /*Prospecto*/
        [Display(Name ="ID")]
        public int iidProspecto { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public string nombreProspecto { get; set; }
        [Required]
        [Display(Name = "Apellido Paterno")]
        public string aPaternoProspecto { get; set; }
        [Display(Name = "Apellido Materno")]
        public string aMaternoProspecto { get; set; }
        [Required]
        [Display(Name = "RFC")]
        public string rfcProspecto { get; set; }
        [Required]
        [Display(Name = "Telefono")]
        public string telefonoProspecto { get; set; }
        [Display (Name ="Estatus")]
        public int estatusProspecto { get; set; }
        [Display(Name ="Observaciones")]
        public string observacionesProspecto { get; set; }


        /*Datos de Prospecto*/
        [Required]
        [Display(Name = "Calle")]
        public string calle { get; set; }
        [Required]
        [Display(Name = "Numero")]
        public string numero { get; set; }
        [Required]
        [Display(Name = "Colonia")]
        public string colonia { get; set; }
        [Required]
        [Display(Name = "Codigo Postal")]
        public int codigoPostal { get; set; }

        /*Documentos*/
        public List<string> documentoList { get; set; }
        [Display(Name ="Tipo de Documento")]
        public string tipoDocumento { get; set; }
        [Display(Name = "Nombre")]
        public string nombreDocumento { get; set; }
    }
}