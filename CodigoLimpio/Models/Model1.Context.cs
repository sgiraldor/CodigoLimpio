﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodigoLimpio.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CodigoMVCEntities : DbContext
    {
        public CodigoMVCEntities()
            : base("name=CodigoMVCEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<empleado> empleado { get; set; }
        public virtual DbSet<EmprendimientoEmpleado> EmprendimientoEmpleado { get; set; }
        public virtual DbSet<Emprendimientos> Emprendimientos { get; set; }
        public virtual DbSet<Emprendimientos4RI> Emprendimientos4RI { get; set; }
        public virtual DbSet<Herramientas4RI> Herramientas4RI { get; set; }
        public virtual DbSet<IdeasConjunto> IdeasConjunto { get; set; }
        public virtual DbSet<ImpactoDepartamento> ImpactoDepartamento { get; set; }
        public virtual DbSet<ImpactoEmprendimiento> ImpactoEmprendimiento { get; set; }
        public virtual DbSet<Impactos> Impactos { get; set; }
    }
}