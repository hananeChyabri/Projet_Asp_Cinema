using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Projet_Cinema_Films.Models
{
    public class CinemaPlaceCreateForm
    {
        [DisplayName("Nom")]
        [Required(ErrorMessage = "Le nom est obligatoire.")]
        public string Name { get; set; }
        [DisplayName("La ville")]
        [Required(ErrorMessage = "Le nom de la ville est obligatoire.")]
        public string city { get; set; }
        [DisplayName("le nom de la rue")]
        [Required(ErrorMessage = "La date de naissance est obligatoire.")]
        public string street { get; set; }
        [DisplayName("le numero")]
        [Required(ErrorMessage = "le numero est obligatoire")]
        public string number { get; set; }
    }
}
