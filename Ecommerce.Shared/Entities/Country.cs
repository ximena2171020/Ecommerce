using System;
using System.ComponentModel.DataAnnotations;


namespace Ecommerce.Shared.Entities
{
    public class Country
    {
        public int id { get; set; }

        [Display(Name ="País")]
        [Required(ErrorMessage = " El campo{0} Es Obligatorio ")]
        [MaxLength(100)]

        public string Name { get; set; }


    }
}
