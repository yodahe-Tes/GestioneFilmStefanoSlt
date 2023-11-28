using System;
using System.Collections.Generic;
using GestioneFilm;
using Newtonsoft.Json;
using Packt.Shared;
using static System.Console;
using static System.Environment;
using static System.IO.Path;
namespace GestioneFilm
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Film mNewFilm = new Film();
            mNewFilm.titolo = " Star Wars";
            mNewFilm.DurataMin = 90;
            mNewFilm.Premio = GenericMedia.premioType.Oscar;
            mNewFilm.Play();
            mNewFilm.minutoCorrente();
            mNewFilm.Stop();
            Console.Write("/nIl film e al minuto " + mNewFilm.minutoCorrente());



            EpisodioSerieTv mNewEpisodio = new();
            mNewEpisodio.titolo = " Andor";
            mNewEpisodio.Stagione = 2;
            mNewEpisodio.NumeroEpisodio = 15;
            mNewEpisodio.DurataMin = 50;
            mNewEpisodio.Play();
            mNewEpisodio.minutoCorrente();
            mNewEpisodio.Stop();
            Console.Write("/n L'episodio e al minuto " + mNewEpisodio.minutoCorrente());




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

            var mListaFilm = new List<Film> { new Film() { titolo = "Tarzan", DurataMin = 90, Premio = GenericMedia.premioType.Oscar },
                                        new Film() { titolo = "Biancaneve", DurataMin = 90, Premio = GenericMedia.premioType.Oscar },
                                        new Film() { titolo = "Hercules", DurataMin = 90, Premio = GenericMedia.premioType.David },
                                        new Film() { titolo = "La sirenetta", DurataMin = 90, Premio = GenericMedia.premioType.Grammy },
                                        mNewFilm
        };


            var ListEpidodi = new List<EpisodioSerieTv>
            {
                new EpisodioSerieTv(){ titolo = "WandaVision", DurataMin = 90, Premio = GenericMedia.premioType.Oscar },
                                        new EpisodioSerieTv() { titolo = "MoonKnight", DurataMin = 90, Premio = GenericMedia.premioType.Oscar },
                                        new EpisodioSerieTv() { titolo = "SheHulk", DurataMin = 90, Premio = GenericMedia.premioType.David },
                                        new EpisodioSerieTv() { titolo = "Falcon&Wintersoldier", DurataMin = 90, Premio = GenericMedia.premioType.Grammy },
                                        mNewEpisodio
            };

            foreach(var episode in ListEpidodi)
            {
                episode.Play();
            }

            var filmSingolo = mListaFilm[0];
            //filmSingolo.titolo.
           string cryptoText =  Protector.Encrypt(mListaFilm.Where(i=> i.titolo.Contains("War")).FirstOrDefault().titolo ,"Jedi");


            // Per criptare titolo
            //string cryptoText = Protector.Encrypt("Text to Encrypt", "Password used to encr");
            //string cryptoText =  Protector.Encrypt(mNewFilm.titolo, "Jedi");

            Console.Write("\n"+cryptoText);


            //Per decriptare titolo
            //string clearText =  Protector.Encrypt("Text to Encrypt", "Password used to encr");
            string clearText = Protector.Decrypt(cryptoText, "Jedi");

            Console.Write("\n"+clearText);


            // Creaiamo una Lista di Episodi


            // Serializzare lista di Film in file
            // Serializzare Episodi in file

            //deserializzare entrambe le liste


            // aggiungere le liste alla lista Generale di interfaccia IMedia


            //Mettere in Play Tutti gli item
            // utilizzando il metodo  dell'interfaccia .Play







            Console.WriteLine("\nHello, World!");
        }
    }
}