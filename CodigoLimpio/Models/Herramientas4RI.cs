//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Herramientas4RI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Herramientas4RI()
        {
            this.Emprendimientos4RI = new HashSet<Emprendimientos4RI>();
        }
    
        public int IdHerramientas4RI { get; set; }
        public string NombreHerramientas4RI { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Emprendimientos4RI> Emprendimientos4RI { get; set; }
    }
}