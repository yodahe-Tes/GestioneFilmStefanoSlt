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
            Console.WriteLine("Inserire la password");
            string readPassword = Console.ReadLine();


            Film mNewFilm = new Film();
            mNewFilm.titolo = " Star Wars";
            mNewFilm.DurataMin = 90;
            mNewFilm.Premio = GenericMedia.premioType.Oscar;
            mNewFilm.PasswordM = readPassword;
            mNewFilm.Play();
            mNewFilm.minutoCorrente();
            
            mNewFilm.Stop();
            Console.WriteLine(mNewFilm.cryptoTitle);
            Console.Write("/nIl film e al minuto " + mNewFilm.minutoCorrente());

            //var budff = mNewFilm.criptoFile;

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

            var mListaFilm = new List<Film> { new Film() { titolo = "Tarzan", DurataMin = 90, Premio = GenericMedia.premioType.Oscar ,PasswordM = readPassword},
                                        new Film() { titolo = "Biancaneve", DurataMin = 90, Premio = GenericMedia.premioType.Oscar ,PasswordM = readPassword},
                                        new Film() { titolo = "Hercules", DurataMin = 90, Premio = GenericMedia.premioType.David,PasswordM = readPassword },
                                        new Film() { titolo = "La sirenetta", DurataMin = 90, Premio = GenericMedia.premioType.Grammy ,PasswordM = readPassword},
                                        mNewFilm
        };


            string jsonPath = Combine(CurrentDirectory, "film.json");

            //Utilizzo la calsse statica del NewtonSoft
            var js2 = JsonConvert.SerializeObject(mListaFilm);
            // Utilizzo File.Write all della classe System.IO ( che gestisce in autonomia lo stream )
            File.WriteAllText(jsonPath, js2);

            // Display the serialized object graph 
            WriteLine(File.ReadAllText(jsonPath));

            //Rileggere il file serializzato appoggiandolo in una stringa
            string buff = File.ReadAllText(jsonPath);

            //Ricrea la lista di Obj Leone a partire dalla stringa Json 
            var loadLeone = JsonConvert.DeserializeObject<List<Film>>(buff);

            WriteLine(File.ReadAllText(jsonPath));

            var loadFilm = JsonConvert.DeserializeObject<List<Film>>(buff);

            mListaFilm.ForEach(item => Console.WriteLine($"Il titolo criptato è : {item.cryptoTitle}"));


            var ListEpidodi = new List<EpisodioSerieTv>
            {
                new EpisodioSerieTv(){ titolo = "WandaVision", DurataMin = 90, Premio = GenericMedia.premioType.Oscar ,PasswordM = readPassword},
                                        new EpisodioSerieTv() { titolo = "MoonKnight", DurataMin = 90, Premio = GenericMedia.premioType.Oscar ,PasswordM = readPassword},
                                        new EpisodioSerieTv() { titolo = "SheHulk", DurataMin = 90, Premio = GenericMedia.premioType.David ,PasswordM = readPassword},
                                        new EpisodioSerieTv() { titolo = "Falcon&Wintersoldier", DurataMin = 90, Premio = GenericMedia.premioType.Grammy,PasswordM = readPassword },
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