//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace evaluacionLECH.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class datos_prospecto
    {
        public int id_datos { get; set; }
        public string calle { get; set; }
        public string numero { get; set; }
        public string colonia { get; set; }
        public Nullable<int> codigo_postal { get; set; }
        public string telefono { get; set; }
        public int id_prospecto { get; set; }
    
        public virtual prospecto prospecto { get; set; }
    }
}