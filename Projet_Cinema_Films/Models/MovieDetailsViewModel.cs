using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Projet_Cinema_Films.Models
{
    public class MovieDetailsViewModel
    {


        [ScaffoldColumn(false)]
        public int Id_Movie { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public short ReleaseYear { get; set; }
        public string Synopsis { get; set; }
        public string PosterUrl { get; set; }
        public int Duration { get; set; }

        public IEnumerable<DiffusionListItemViewModels> Diffusions { get; set; }
    }
}
