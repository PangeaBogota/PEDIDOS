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
    
    public partial class ListaPrecio
    {
        public ListaPrecio()
        {
            this.Precio = new HashSet<Precio>();
            this.Sucursal = new HashSet<Sucursal>();
        }
    
        public int RowID { get; set; }
        public Nullable<int> RowIDERP { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
    
        public virtual ICollection<Precio> Precio { get; set; }
        public virtual ICollection<Sucursal> Sucursal { get; set; }
    }
}
