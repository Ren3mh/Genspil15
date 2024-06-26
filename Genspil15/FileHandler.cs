﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genspil15
{
    public class Filehandler
    {
        private string dataFileName;

        public string DataFileName
        {
            get { return dataFileName; }
        }

        public Filehandler(string DataFileName)
        {
            dataFileName = DataFileName;

        }

        public static List<Game> ReadGamesFromFile(string dataFileName)
        {
            List<Game> games = new List<Game>();
            string line;
            try
            {
                using StreamReader sr = new StreamReader(dataFileName);
                line = sr.ReadLine();

                while (line != null)
                {
                    string[] parts = line.Split('/');
                    string gameName = parts[0];
                    string gameEdition = parts[1];
                    Genre genre = Enum.Parse<Genre>(parts[2]);
                    int numberOfPlayersMin = int.Parse(parts[3]);
                    int numberOfPlayersMax = int.Parse(parts[4]);
                    int ageMin = int.Parse(parts[5]);
                    double price = double.Parse(parts[6]);
                    Condition condition = Enum.Parse<Condition>(parts[7]);
                    int quantityOfGames = int.Parse(parts[8]);
                    bool reserved = bool.Parse(parts[9]);
                    string waitlist = parts[10];

                    games.Add(new Game(gameName, gameEdition, genre, numberOfPlayersMin, numberOfPlayersMax, ageMin, price, (Condition)condition, quantityOfGames, reserved, waitlist));
                    line = sr.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fejl ved læsning" + ex.Message);
            }
            return games;
            
        }

        public static void WriteGamesToFile(List<Game> games, string fileName)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fileName)) //Sæt , True efter fileName for at StreamWriter appender/tilføjer til listen
                {
                    foreach (var game in games)
                    {
                        sw.WriteLine($"{game.GameName}/{game.GameEdition}/{game.Genre.ToString()}/{game.NumberOfPlayersMin}/{game.NumberOfPlayersMax}/{game.AgeMin}/{game.Price}/{game.Condition}/{game.QuantityOfGame}/{game.Reserved}/{game.Waitlist}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Fejl:" + ex.Message);
            }
        }
    }
}
