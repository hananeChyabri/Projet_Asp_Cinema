using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Projet_Cinema_Films.Models
{
    public class CinemaPlaceDetails
    {
     

        [ScaffoldColumn(false)]
        public int Id_CinemaPlace { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }

        // public IEnumerable<DiffusionDetails> Diffusions { get; set; }
    }
}
