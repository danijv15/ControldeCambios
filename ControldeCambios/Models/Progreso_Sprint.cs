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
    
    public partial class Progreso_Sprint
    {
        public System.DateTime fecha { get; set; }
        public string sprintProyecto { get; set; }
        public int sprintNumero { get; set; }
        public int puntos { get; set; }
    
        public virtual Sprint Sprint { get; set; }
    }
}
