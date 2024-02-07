using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Projet_Cinema_Films.Models
{
    public class MovieDeleteForm
    {
        [DisplayName("Identifiant")]
        [ScaffoldColumn(false)]
        public int Id_Movie { get; set; }

        [DisplayName("Movie: ")]
        public string Title { get; set; }
        [DisplayName("Year Release: ")]
        public short ReleaseYear { get; set; }
 
    }
}
