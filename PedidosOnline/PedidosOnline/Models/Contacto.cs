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
    
    public partial class Contacto
    {
        public Contacto()
        {
            this.Actividad = new HashSet<Actividad>();
        }
    
        public int RowID { get; set; }
        public string Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Skype { get; set; }
        public string Descripcion { get; set; }
        public string ruta_imagen { get; set; }
        public string Celular { get; set; }
        public string Cargo { get; set; }
        public string Area { get; set; }
        public string UsuarioCreacion { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public Nullable<int> SucursalID { get; set; }
    
        public virtual ICollection<Actividad> Actividad { get; set; }
    }
}
