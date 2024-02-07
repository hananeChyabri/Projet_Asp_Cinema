using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Projet_Cinema.Entities
{
    public class Movie
    {
        public int Id_Movie { get; private set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public short ReleaseYear { get; set; }
        public string Synopsis { get; set; }
        public string PosterUrl { get; set; }
        public int Duration { get; set; }

        public Movie(int id_Movie, string title, string subTitle, short releaseYear, string synopsis, string posterUrl, int duration)
        {
            Id_Movie = id_Movie;
            Title = title;
            SubTitle = subTitle;
            ReleaseYear = releaseYear;
            Synopsis = synopsis;
            PosterUrl = posterUrl;
            Duration = duration;
        }
    }
}
