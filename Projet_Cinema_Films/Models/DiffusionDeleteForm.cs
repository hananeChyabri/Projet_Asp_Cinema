using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;

namespace Projet_Cinema_Films.Models
{
    public class DiffusionDeleteForm
    {

        [DisplayName("Identifiant")]
        [ScaffoldColumn(false)]
        public int Id_Diffusion { get; set; }
        [DisplayName("Date")]
        [DataType(DataType.Date)]
        public DateTime DiffusionDate { get; set; }
        public TimeSpan DiffusionTime { get; set; }
        [DisplayName("Identifiant du cinemaPlace")]
        public int Id_cinemaPlace { get; set; }


    }
}
