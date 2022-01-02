using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace evaluacionLECH.Models
{
    public class CapturaCLS
    {
        public int iidprospecto { get; set; }
        [Display(Name ="Nombre")]
        public string nombreprospecto { get; set; }
        [Display(Name = "Apellido Paterno")]
        public string aPaternoprospecto { get; set; }
        [Display(Name = "Apellido Materno")]
        public string aMaternoprospecto { get; set; }
        [Display(Name = "RFC")]
        public string rfcprospecto { get; set; }
        public int estatus { get; set; }

    }
}