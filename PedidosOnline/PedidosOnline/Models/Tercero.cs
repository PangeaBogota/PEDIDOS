//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Tercero
    {
        public Tercero()
        {
            this.Sucursal = new HashSet<Sucursal>();
            this.Sucursal1 = new HashSet<Sucursal>();
            this.PuntoEnvio = new HashSet<PuntoEnvio>();
            this.Usuario = new HashSet<Usuario>();
        }
    
        public int RowID { get; set; }
        public Nullable<int> RowIDERP { get; set; }
        public string Identificacion { get; set; }
        public Nullable<int> TipoIdentificacion { get; set; }
        public string RazonSocial { get; set; }
        public string NombreComercial { get; set; }
        public Nullable<short> Vendedor { get; set; }
        public Nullable<short> Cliente { get; set; }
        public Nullable<short> Proveedor { get; set; }
        public Nullable<short> Accionista { get; set; }
        public string CodigoVendedorERP { get; set; }
        public Nullable<int> ContactoERPID { get; set; }
        public Nullable<bool> Activo { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
    
        public virtual ContactoERP ContactoERP { get; set; }
        public virtual ICollection<Sucursal> Sucursal { get; set; }
        public virtual ICollection<Sucursal> Sucursal1 { get; set; }
        public virtual ICollection<PuntoEnvio> PuntoEnvio { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
