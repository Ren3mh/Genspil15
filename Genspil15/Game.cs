using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Genspil15
{
    public class Game
    {
        public string GameName { get; set; } = "ukendt";
        public string GameEdition { get; set; } = "ukendt";
        public string Genre { get; set; } = "ukendt";
        public int NumberOfPlayersMin { get; set; } = 0;
        public int NumberOfPlayersMax { get; set; } = 0;
        public int AgeMin { get; set; } = 0;
        public double Price { get; set; } = 0;
        public int Condition { get; set; } = 0;
        public int QuantityOfGame { get; set; } = 0;
        public string[] Waitlist { get; set; } = new string[0];
        public string[] Reserved { get; set; } = new string[0];
        public bool BeingRepaired { get; set; } = false;

        public Game() 
        { 
            //Tom Constructor
        }

        public Game(string gameName, string gameEdition, string genre, int numberOfPlayersMin, int numberOfPlayersMax, int ageMin, double price, int condition, int quantityOfGame, bool beingRepaired)
        {
            GameName = gameName;
            GameEdition = gameEdition;
            Genre = genre;
            NumberOfPlayersMin = numberOfPlayersMin;
            NumberOfPlayersMax = numberOfPlayersMax;
            AgeMin = ageMin;
            Price = price;
            Condition = condition;
            QuantityOfGame = quantityOfGame;
            BeingRepaired = beingRepaired;
        }

        public void CreateGame()
        {
            Game Name = new Game();
            Console.WriteLine("Du har valgt at tilføje et nyt spil...");
            Console.WriteLine("Hvad er navnet?");
            Console.ReadLine();
        }

        public string MakeTitle()
        {
            return GameName + ", " + GameEdition + ", " + Genre + ", " + NumberOfPlayersMin + ", " + NumberOfPlayersMax + ", " + AgeMin + ", " + Price + ", " + Condition + ", " + QuantityOfGame;
        }
    }
}
