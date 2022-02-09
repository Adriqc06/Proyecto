using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.Models
{
    public class Usuario
    {
        [Key]

        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "Longitud mínima no alcanza", MinimumLength = 3)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La direccion es obligatoria")]
        [StringLength(50, ErrorMessage = "Longitud mínima no alcanza", MinimumLength = 3)]
        [Display(Name = "Direccion")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El Telefono es obligatorio")]
        [StringLength(50, ErrorMessage = "Longitud mínima no alcanza", MinimumLength = 3)]
        [Display(Name = "Telefono")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El Coidgo Postal es obligatorio")]
        [StringLength(50, ErrorMessage = "Longitud mínima no alcanza", MinimumLength = 3)]
        [Display(Name = "Codigo Postal")]
        public string CodigoPostal { get; set; }

        [Required(ErrorMessage = "El Tipo de usuario es obligatorio")]
        [StringLength(50, ErrorMessage = "Longitud mínima no alcanza", MinimumLength = 3)]
        [Display(Name = "Tipo de usuario")]
        public string Tipo_usuario { get; set; }

        [Required(ErrorMessage = "El Estado es obligatorio")]
        [StringLength(50, ErrorMessage = "Longitud mínima no alcanza", MinimumLength = 3)]
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "La ciudad es obligatoria")]
        [StringLength(50, ErrorMessage = "Longitud mínima no alcanza", MinimumLength = 3)]
        [Display(Name = "Ciudad")]
        public string Ciudad { get; set; }

    }
}
