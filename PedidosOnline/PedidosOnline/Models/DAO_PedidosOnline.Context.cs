﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PedidosOnline.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PedidosOnlineEntities : DbContext
    {
        public PedidosOnlineEntities()
            : base("name=PedidosOnlineEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Actividad> Actividad { get; set; }
        public virtual DbSet<Contacto> Contacto { get; set; }
        public virtual DbSet<Ciudad> Ciudad { get; set; }
        public virtual DbSet<Compañia> Compañia { get; set; }
        public virtual DbSet<ContactoERP> ContactoERP { get; set; }
        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<ListaPrecio> ListaPrecio { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Precio> Precio { get; set; }
        public virtual DbSet<Sucursal> Sucursal { get; set; }
        public virtual DbSet<Tercero> Tercero { get; set; }
        public virtual DbSet<AgenteNaviera> AgenteNaviera { get; set; }
        public virtual DbSet<Agrupacion> Agrupacion { get; set; }
        public virtual DbSet<Opcion> Opcion { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Modulo> Modulo { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<RolMenu> RolMenu { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<PuntoEnvio> PuntoEnvio { get; set; }
    }
}
