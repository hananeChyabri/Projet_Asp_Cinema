using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Projet_Cinema_Films.Models
{
    public class MovieListItemViewModels
    {
        [ScaffoldColumn(false)]
        public int Id_Movie { get; set; }
        [DisplayName("Title")]
        public string Title { get; set; }

        [DisplayName("SubTitle")]
        public string Subtitle { get; set; }

        [DisplayName("Release Year")]
        public short ReleaseYear { get; set; }

        [DisplayName("Synopsis")]
        public string Synopsis { get; set; }

        [DisplayName("Poste Url")]
        public string PosterUrl { get; set; }

        [DisplayName("Duration")]
        public int Duration { get; set; }
    }
}
