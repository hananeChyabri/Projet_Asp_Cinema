using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Projet_Cinema_Films.Models
{
    public class CinemaPlaceDelete
    {
        [DisplayName("Identifiant")]
        [ScaffoldColumn(false)]
        public int Id_CinemaPlace { get; set; }

        [DisplayName("Cinema: ")]
        public string Name { get; set; }
    }
}
