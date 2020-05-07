using System.ComponentModel.DataAnnotations;

namespace Soccer.Web.Data.Entity
{
    public class TeamEntity
    {
        public int Id { get; set; }
        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "el campo es {0} no puede tener mas de {1} caracteres")]
        [Required(ErrorMessage = "el campo es {0} obligatorio")]
        public string Name { get; set; }
        [Display(Name = "Logo")]
        public string LogoPath { get; set; }
    }
}
