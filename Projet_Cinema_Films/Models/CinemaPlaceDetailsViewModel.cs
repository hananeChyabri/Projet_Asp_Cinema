using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Projet_Cinema_Films.Models
{
    public class CinemaPlaceDetailsViewModel
    {
     

        [ScaffoldColumn(false)]
        public int Id_CinemaPlace { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }

        [DisplayName("toute les diffusions")]
        public IEnumerable<DiffusionListItemViewModels> Diffusions { get; set; }
        [DisplayName("La liste des salles")]
        public IEnumerable<CinemaRoomListItemViewModels> CinemaRooms { get; set; }
    }
}
