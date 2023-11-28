using System;
using System.Collections.Generic;
using GestioneFilm;
using Newtonsoft.Json;
using static System.Console;
using static System.Environment;
using static System.IO.Path;
namespace GestioneFilm // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Film mNewFilm = new Film();
            mNewFilm.titolo = "Star Wars";
            mNewFilm.DurataMin = 3;
            mNewFilm.Premio = GenericMedia.premioType.David;
            mNewFilm.Play();

            EpisodioSerieTv mNewEpisodio = new();
            mNewEpisodio.titolo = "Andor";
            mNewEpisodio.Stagione = 2;
            mNewEpisodio.NumeroEpisodio = 15;

            mNewEpisodio.Stop();
            mNewFilm.Stop();


            //Interfaccia IMedia 
            //Titolo // string
            //DurataMin // int
            //Premio // Tipologia Enum
            //Metodo // Play




            //Film 
            // Titolo---
            // Durata---
            // Premio ----
            //Tipologia Premio Enum


            //Episodio TV
            //Titolo----
            //Durata---
            //Stagioni
            //Numero Episodio
            //Premio----
            //Tipologia Premio Enum



            //File Audio
            // tipologia File //.mp3 ...





            //Creare una lista di Film

            // Creaiamo una Lista di Episodi


            // Serializzare lista di Film in file
            // Serializzare Episodi in file

            //deserializzare entrambe le liste


            // aggiungere le liste alla lista Generale di interfaccia IMedia


            //Mettere in Play Tutti gli item
            // utilizzando il metodo  dell'interfaccia .Play

            Console.WriteLine("Hello World!");
        }
    }
}