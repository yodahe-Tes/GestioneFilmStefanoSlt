using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneFilm
{
    internal class Film : GenericMedia
    {

        public override void Play()
        {
            Console.WriteLine("\n Il titolo del film è " + titolo + " e al minuto  " + DurataMin + " Ha ricevuto il premio "+ Premio);
        }

    }
}