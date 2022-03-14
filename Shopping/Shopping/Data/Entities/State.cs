using System.ComponentModel.DataAnnotations;

namespace Shopping.Data.Entities
{
    public class State 
    {
        public int Id { get; set; }
        [Display(Name = "Departamento/Estado")]
        [MaxLength(50, ErrorMessage = "El campó{0} debe tener máximo {1} caractéres.")]
        [Required(ErrorMessage = "El campo {0} es obligatorio. ")]

        public string Name { get; set; }

        public Country Country { get; set; }

        public ICollection<City> Cities { get; set; }

        [DisplayAttribute(Name="Ciudades")]
        public int CitiesNumber => Cities == null ? 0 : Cities.Count;



    }


}

