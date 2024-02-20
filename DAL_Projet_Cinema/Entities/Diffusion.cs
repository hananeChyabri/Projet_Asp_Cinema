using System;
using System.Collections.Generic;
using System.Text;

namespace DAL_Projet_Cinema.Entities
{
    public class Diffusion
    {
    
        public int Id_Diffusion { get; set; }

        public DateTime DiffusionDate { get; set; }
        public TimeSpan DiffusionTime { get; set; }
        public string AudioLang { get; set; }
        public string? SubTitleLang { get; set; }

        public int Id_CinemaPlace { get; set; }
        public int Id_CinemaRoom { get; set; }
        public int Id_Movie { get; set; }
        public CinemaRoom CinemaRoom { get; set; }
 
        public Movie Movie { get; set; }
    }
}
