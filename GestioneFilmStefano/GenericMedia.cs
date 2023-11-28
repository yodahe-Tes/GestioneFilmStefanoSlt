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

        public enum premioType { Oscar, David, Grammy };
        public premioType Premio { get; set; }


        public abstract void Play();

        public void Stop()
        {
            Console.WriteLine("Media in pausa");
        }

        public int minutoCorrente()
        {
            return new Random().Next(1, DurataMin + 1);
        }
    }
    
}