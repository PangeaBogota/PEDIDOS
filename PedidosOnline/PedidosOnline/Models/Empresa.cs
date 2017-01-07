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
    
    public partial class Empresa
    {
        public Empresa()
        {
            this.Compañia = new HashSet<Compañia>();
        }
    
        public int RowID { get; set; }
        public Nullable<int> RowIDERP { get; set; }
        public string Nit { get; set; }
        public string RazonSocial { get; set; }
        public Nullable<bool> Activo { get; set; }
        public Nullable<int> ErpID { get; set; }
        public Nullable<int> IdiomaID { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
    
        public virtual ICollection<Compañia> Compañia { get; set; }
        public virtual Opcion Opcion { get; set; }
        public virtual Opcion Opcion1 { get; set; }
    }
}
