﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class evaluacionBDEntities : DbContext
    {
        public evaluacionBDEntities()
            : base("name=evaluacionBDEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<datos_prospecto> datos_prospecto { get; set; }
        public virtual DbSet<documentos> documentos { get; set; }
        public virtual DbSet<prospecto> prospecto { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
    }
}
