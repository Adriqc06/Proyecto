using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El usuario es obligatorio")]
        [StringLength(50, ErrorMessage = "Longitud mínima no alcanza", MinimumLength = 3)]
        [Display(Name = "Usuario")]
        public string User { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [StringLength(50, ErrorMessage = "Longitud mínima no alcanza", MinimumLength = 3)]
        [Display(Name = "Contraseña")]
        public string Pass { get; set; }

    }
}
