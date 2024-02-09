using BLL_Projet_Cinema.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Projet_Cinema_Films.Models
{
    public class CinemaRoomCreateForm
    {

        [DisplayName("Sits Count")]
        [Required(ErrorMessage = "Ce champ est obligatoire.")]
        public int SitsCount { get; set; }

        [DisplayName("Number")]
        [Required(ErrorMessage = "Ce champ est obligatoire.")]
        public int Number { get; set; }

        [DisplayName("Screen Width")]
        [Required(ErrorMessage = "Ce champ est obligatoire.")]
        public int ScreenWidth { get; set; }

        [DisplayName("Screen Height")]
        [Required(ErrorMessage = "Ce champ est obligatoire.")]
        public int ScreenHeight { get; set; }

        [DisplayName("Can3D")]
        [Required(ErrorMessage = "Ce champ est obligatoire.")]
        public bool Can3D { get; set; }

        [DisplayName("Can4DX")]
        [Required(ErrorMessage = "Ce champ est obligatoire.")]
        public bool Can4DX { get; set; }

        [DisplayName("CinemaPlace")]
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public int Id_cinemaPlace { get; set; }


    }
}
