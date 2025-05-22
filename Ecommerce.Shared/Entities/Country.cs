using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;


namespace Ecommerce.Shared.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name = "País")]
        [Required(ErrorMessage = " El campo{0} Es Obligatorio ")]
        [MaxLength(100)]

        public required string Name { get; set; }

        public required ICollection<State> States { get; set; }

        [Display(Name ="Estados/Departamentos")]

        public int StatesNumber => States == null ? 0:States.Count();
    }
}
