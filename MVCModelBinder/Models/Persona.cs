using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCModelBinder.Models
{
    public class Persona
    {
        [Required]
        [MaxLength(50, ErrorMessage = "Máximo número de carácteres superado (50)")]
        public string NombreCompleto { get; set; }

        [Range(18, 80)]
        [Required(ErrorMessage = "Introduzca una edad")]
        public Int32 Edad { get; set; }

    }
}