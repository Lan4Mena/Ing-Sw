﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBEsparzaSeguridadEntities : DbContext
    {
        public DBEsparzaSeguridadEntities()
            : base("name=DBEsparzaSeguridadEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DETALLE_CONTRATO> DETALLE_CONTRATO { get; set; }
        public virtual DbSet<TBL_CLIENTE_CORREOS> TBL_CLIENTE_CORREOS { get; set; }
        public virtual DbSet<TBL_CLIENTE_TELEFONOS> TBL_CLIENTE_TELEFONOS { get; set; }
        public virtual DbSet<TBL_CLIENTES> TBL_CLIENTES { get; set; }
        public virtual DbSet<TBL_CONTRATOS> TBL_CONTRATOS { get; set; }
        public virtual DbSet<TBL_INVENTARIO> TBL_INVENTARIO { get; set; }
        public virtual DbSet<TBL_INVENTARIO_OFICIALES> TBL_INVENTARIO_OFICIALES { get; set; }
        public virtual DbSet<TBL_OFICIALES> TBL_OFICIALES { get; set; }
        public virtual DbSet<TBL_TIPO_CEDULAS> TBL_TIPO_CEDULAS { get; set; }
        public virtual DbSet<TBL_USUARIOS> TBL_USUARIOS { get; set; }
    }
}
