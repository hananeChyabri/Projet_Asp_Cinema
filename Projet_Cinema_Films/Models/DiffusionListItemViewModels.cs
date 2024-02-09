using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using DAL_Projet_Cinema.Entities;
using BLL_Projet_Cinema.Entities;

namespace Projet_Cinema_Films.Models
{
    public class DiffusionListItemViewModels
    {
        [DisplayName("Date")]
        [DataType(DataType.Date)]
        public DateTime DiffusionDate { get; set; }
        public TimeSpan DiffusionTime { get; set; }
        public Languages AudioLang { get; set; }
        public Languages? SubTitleLang { get; set; }
        public string  TitleMovie { get; set; }
        public string Subtitle {  get; set; }
        public int Duration {  get; set; }  
        public string TypeProjection {  get; set; }

        public int NumeroCinemaRoom {  get; set; }

        [ScaffoldColumn(false)]
        public int Id_Movie { get; set; }


        [ScaffoldColumn(false)]
        public int Id_CinemaRoom { get; set; }

    }
}
