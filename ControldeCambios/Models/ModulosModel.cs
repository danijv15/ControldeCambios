﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControldeCambios.Models
{
    /// <summary>
    /// Provee modelado para los objetos de tipo Modulo
    /// </summary>
    public class ModulosModel
    {
        [Required(ErrorMessage = "El nombre es un campo requerido.")]
        [StringLength(25, ErrorMessage = "El nombre debe ser de {1} dígitos"), MinLength(1, ErrorMessage = "El nombre debe ser de almenos {1} dígitos")]
        [Display(Name = "Nombre")]
        [RegularExpression(@"^[A-Za-z0-9\s]+$", ErrorMessage = "El nombre solo debe contener letras y espacios")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "El proyecto es un campo requerido.")]
        [Display(Name = "Proyecto")]
        public string proyecto { get; set; }

        public List<string> requerimientos { get; set; }

        public class reqInfo {
            public string id { get; set; }
            public string nombre { get; set; }
        }
    }
}