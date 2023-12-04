using GestioneFilm;
using System;

namespace GestioneFilm
{
    internal class EpisodioSerieTv : GenericMedia
    {


        public int Stagione;
        public int NumeroEpisodio;


        public override void Play()
        {
             
            Console.WriteLine("\n Il titolo dell'episodio è " + titolo + "\n Il numero dell'episodio è " + NumeroEpisodio +
                "\nLa stagione dell'episodio è " + Stagione + " \nLa durata dell'episodio è  " + DurataMin + "\n Ha ricevuto il premio " + Premio);
        }
    }
}