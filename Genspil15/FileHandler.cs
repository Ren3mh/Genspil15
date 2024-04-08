using System;
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
                    string[] parts = line.Split(',');
                    string gameName = parts[0];
                    string gameEdition = parts[1];
                    string genre = parts[2];
                    int numberOfPlayersMin = int.Parse(parts[3]);
                    int numberOfPlayersMax = int.Parse(parts[4]);
                    double price = double.Parse(parts[5]);
                    int condition = int.Parse(parts[6]);
                    int quantityOfGames = int.Parse(parts[7]);


                    games.Add(new Game(gameName, gameEdition, genre, numberOfPlayersMin, numberOfPlayersMax, price, condition, quantityOfGames));
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
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    foreach (var game in games)
                    {
                        sw.WriteLine($"{game.GameName}, {game.GameEdition}, {game.Genre}, {game.NumberOfPlayersMin}, {game.NumberOfPlayersMax}, {game.Price}, {game.Condition}, {game.QuantityOfGame}");
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
