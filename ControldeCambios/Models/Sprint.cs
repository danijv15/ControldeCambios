//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ControldeCambios.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sprint
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sprint()
        {
            this.Progreso_Sprint = new HashSet<Progreso_Sprint>();
            this.Requerimientos = new HashSet<Requerimiento>();
        }
    
        public string proyecto { get; set; }
        public int numero { get; set; }
        public System.DateTime fechaInicio { get; set; }
        public System.DateTime fechaFinal { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Progreso_Sprint> Progreso_Sprint { get; set; }
        public virtual Proyecto Proyecto1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Requerimiento> Requerimientos { get; set; }
    }
}
