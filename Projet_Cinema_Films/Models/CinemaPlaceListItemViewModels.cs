using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Projet_Cinema_Films.Models
{
    public class CinemaPlaceListItemViewModels
    {
        [ScaffoldColumn(false)]
        public int Id_CinemaPlace { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }

        //[ScaffoldColumn(false)]
        [DisplayName("City")]
        public string City { get; set; }

        //[ScaffoldColumn(false)]
        [DisplayName("Street")]
        public string Street { get; set; }

        //[ScaffoldColumn(false)]
        [DisplayName("Number")]
        public string Number { get; set; }
    


    }
}
