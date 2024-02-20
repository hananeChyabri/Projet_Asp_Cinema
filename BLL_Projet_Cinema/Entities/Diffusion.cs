using DAL_Projet_Cinema.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Projet_Cinema.Entities
{
    public class Diffusion
    {
     

        public int Id_Diffusion { get; set; }
        public DateTime DiffusionDate { get; set; }
        public TimeSpan DiffusionTime { get; set; }
        public Languages AudioLang { get; set; }
        public Languages? SubTitleLang { get; set; }

        public int Id_CinemaPlace { get; set; }
        public int Id_CinemaRoom { get; set; }
        public int Id_Movie { get; set; }
        public CinemaRoom CinemaRoom { get; set; }

        public Movie Movie { get; set; }

        public CinemaPlace cinemaPlace { get; set;}

        public Diffusion(int id_Diffusion, DateTime diffusionDate, TimeSpan diffusionTime, Languages audioLang, Languages? subTitleLang, int id_CinemaPlace, int id_CinemaRoom, int id_Movie)
        {
            Id_Diffusion = id_Diffusion;
            DiffusionDate = diffusionDate;
            DiffusionTime = diffusionTime;
            AudioLang = audioLang;
            SubTitleLang = subTitleLang;
            Id_CinemaPlace = id_CinemaPlace;
            Id_CinemaRoom = id_CinemaRoom;
            Id_Movie = id_Movie;
         

        }

        public Diffusion(int id_Diffusion, DateTime diffusionDate, TimeSpan diffusionTime, Languages audioLang, Languages? subTitleLang, int id_CinemaRoom, int id_Movie)
        {
            Id_Diffusion = id_Diffusion;
            DiffusionDate = diffusionDate;
            DiffusionTime = diffusionTime;
            AudioLang = audioLang;
            SubTitleLang = subTitleLang;
            Id_CinemaRoom = id_CinemaRoom;
            Id_Movie = id_Movie;


        }

    }
}
