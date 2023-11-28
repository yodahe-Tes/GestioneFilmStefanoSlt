using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneFilm
{
    public abstract class GenericMedia : IMedia
    {
        public int DurataMin { get; set; }
        public string? titolo;
        //public enum Premio { Oscar, David, Grammy };

        public abstract void Play();

    }
}