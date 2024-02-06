using System;
using System.Collections.Generic;
using System.Text;

namespace BLL_Projet_Cinema.Entities
{
    public class CinemaPlace
    {

        private List<Diffusion> _diffusions;
        public int Id_CinemaPlace { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }

        public Diffusion[] Diffusions
        {
            get
            {
                return _diffusions?.ToArray() ?? new Diffusion[0];
            }
        }

        public CinemaPlace(int id_CinemaPlace, string name, string city, string street, string number)
        {
            Id_CinemaPlace = id_CinemaPlace;
            Name = name;
            City = city;
            Street = street;
            Number = number;
        }

        public void AddDiffusions(IEnumerable<Diffusion> diffusions)
        {
            if (diffusions is null) throw new ArgumentNullException(nameof(diffusions));
            foreach (Diffusion diffusion in diffusions)
            {
                AddDiffusion(diffusion);
            }
        }

        public void AddDiffusion(Diffusion diffusion)
        {
            _diffusions ??= new List<Diffusion>();
            //if (diffusion is null) throw new ArgumentNullException(nameof(diffusion));
            //if (_diffusions.Contains(diffusion)) throw new ArgumentException(nameof(diffusion), $"la diffusion {diffusion.Id_Diffusion} existe deja.");
            //if ((!(student.Section is null) && student.Section != this) || student.Section_id != this.Section_id) throw new ArgumentException(nameof(student), $"L'étudiant {student.Student_id} est déjà inscrit dans une section différente.");

            _diffusions.Add(diffusion);
        }

    }
}
