using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Shared.DTOs
{
    public class LoginDTO
    {
        [Required(ErrorMessage = "El campo {0} Es Requerido")]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]

        public string Email { get; set; }


        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "El campo {0} Es Requerido")]
        [StringLength(6, ErrorMessage = "El Campo {0} debe tener al menos {1} caracteres")]

        public string Password { get; set; }

    }
}
