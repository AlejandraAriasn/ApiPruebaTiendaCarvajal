//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PruebaCarvajal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EncabezadoCompra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EncabezadoCompra()
        {
            this.DetalleCompra = new HashSet<DetalleCompra>();
        }
    
        public long IdRecord { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public long IdUsuario { get; set; }
        public Nullable<decimal> SubTotal { get; set; }
        public Nullable<decimal> Impuestos { get; set; }
        public Nullable<decimal> Total { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleCompra> DetalleCompra { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}
