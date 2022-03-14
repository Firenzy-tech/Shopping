﻿using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class Country
    {
        public int Id { get; set; }
        [Display(Name = "País")]
        [MaxLength(50, ErrorMessage = "El campó{0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio. ")]


        public string Name { get; set; }

        public ICollection<State> States { get; set; }
        [Display(Name = "Departamentos/estados")]


        public int StatesNumber => States == null ? 0 : States.Count;

    }
}
