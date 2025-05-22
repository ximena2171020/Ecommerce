﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Shared.DTOs
{
    public class EmailDTO
    {
        [Required(ErrorMessage = "El campo {0} Es Requerido")]
        [EmailAddress(ErrorMessage = "El campo debe ser Obligatorio")]
        [Display(Name = "Email")]

        public string Email { get; set; }
    }
}
