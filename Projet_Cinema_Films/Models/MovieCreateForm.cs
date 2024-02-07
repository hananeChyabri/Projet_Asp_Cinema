using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Projet_Cinema_Films.Models
{
    public class MovieCreateForm
    {
        [DisplayName("Title")]
        [Required(ErrorMessage = "Le nom est obligatoire.")]
        public string Title { get; set; }
        [DisplayName("SubTitle")]
        public string SubTitle { get; set; }
        [DisplayName("Release Year")]
        [Required(ErrorMessage = "l'annee est obligatoire")]
        public short ReleaseYear { get; set; }
        [DisplayName("Synopsis")]
        [Required(ErrorMessage = "le Synopsis est obligatoire")]
        public string Synopsis { get; set; }

        [DisplayName("PosterUrl")]
        [Required(ErrorMessage = "le PosterUrl est obligatoire")]
        public string PosterUrl { get; set; }

        [DisplayName("Duration")]
        [Required(ErrorMessage = "la Duration est obligatoire")]
        public int Duration { get; set; }

    }

}
