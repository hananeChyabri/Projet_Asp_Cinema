using BLL_Projet_Cinema.Entities;
using DAL_Projet_Cinema.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Projet_Cinema_Films.Models
{
    public class DiffusionCreateForm
    {
        [DisplayName("Diffusion Date")]
        [Required(ErrorMessage = "Ce champ est obligatoire.")]
        public DateTime DiffusionDate { get; set; }
       
        [DisplayName("DiffusionTime")]
        [Required(ErrorMessage = "Ce champ est obligatoire.")]
        public TimeSpan DiffusionTime { get; set; }
   
        [DisplayName("Audio Lang")]
        [Required(ErrorMessage = "Ce champ est obligatoire.")]
        public Languages AudioLang { get; set; }
   
        [DisplayName("SubTitleLang")]
        [Required(ErrorMessage = "Ce champ est obligatoire.")]
        public Languages SubTitleLang { get; set; }

        [DisplayName("CinemaRoom")]
        [Required(ErrorMessage = "Ce champ est obligatoire.")]
        public int Id_CinemaRoom { get; set; }

        [DisplayName("Movie")]
        [Required(ErrorMessage = "Ce champ est obligatoire.")]
        public int Id_Movie { get; set; }

    }
}
