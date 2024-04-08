using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Genspil15
{
    public class Game
    {
        public string GameName { get; set; }
        public string GameEdition { get; set; }
        public string Genre { get; set; }
        public int NumberOfPlayersMin { get; set; }
        public int NumberOfPlayersMax { get; set; }
        public double Price { get; set; }
        public int Condition { get; set; }
        public int QuantityOfGame { get; set; }
        public string[] Waitlist { get; set; }
        public string[] Reserved {  get; set; }
        public bool BeingRepaired { get; set; }


        public Game(string gameName, string gameEdition, string genre, int numberOfPlayersMin, int numberOfPlayersMax, double price, int condition, int quantityOfGame)
        {
            GameName = gameName;
            GameEdition = gameEdition;
            Genre = genre;
            NumberOfPlayersMin = numberOfPlayersMin;
            NumberOfPlayersMax = numberOfPlayersMax;
            Price = price;
            Condition = condition;
            QuantityOfGame = quantityOfGame;
        }

        public string MakeTitle()
        {
            return GameName + ", " + GameEdition + ", " + Genre + ", " + NumberOfPlayersMin + ", " + NumberOfPlayersMax + ", " + Price + ", " + Condition + ", " + QuantityOfGame;
        }
    }
}
