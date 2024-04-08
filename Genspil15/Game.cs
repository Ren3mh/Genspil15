using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Resources;
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

        public string CreateGame()
        {
            
            Console.WriteLine("Du har valgt at tilføje et nyt spil...");

            Console.WriteLine("Hvad er navnet?");
            GameName = Console.ReadLine();

            Console.WriteLine("Hvad er versionen/edition? (Hvis ingen, tryk enter...)");
            GameEdition = Console.ReadLine();

            Console.WriteLine("Hvad er genren?");
            Genre = Console.ReadLine();

            Console.WriteLine("Hvad er det mindst mulige antalspillere?");
            NumberOfPlayersMin = int.Parse(Console.ReadLine());

            Console.WriteLine("Hvad er det størst mulige antalspillere?");
            NumberOfPlayersMax = int.Parse(Console.ReadLine());

            Console.WriteLine("Hvad er aldersgrænsen?");
            AgeMin = int.Parse(Console.ReadLine());

            Console.WriteLine("Hvad er prisen?");
            Price = double.Parse(Console.ReadLine());

            Console.WriteLine("Hvad er tilstanden på spillet? fra 1-4 (1: som ny, 2: god, 3: slidt, 4: skal reperares)");
            Condition = int.Parse(Console.ReadLine());

            Console.WriteLine("Er der mere end 1 spil som dette? hvis ja, hvor mange?");
            QuantityOfGame = int.Parse(Console.ReadLine());

            Console.WriteLine("Er den til reperation? y eller n");
            string yayornay = Console.ReadLine();

                if (yayornay == "y")
                {
                    Console.WriteLine("Du har sat spillet som værende til reperation...");
                    BeingRepaired = true;
                }
                else 
                {
                    BeingRepaired = false;
                }


            Console.WriteLine("Du har oprettet følgende spil:");
            Console.WriteLine(MakeTitle());
            MakeTitle();
            return MakeTitle();


        }

        public string MakeTitle()
        {
            return GameName + ", " + GameEdition + ", " + Genre + ", " + NumberOfPlayersMin + ", " + NumberOfPlayersMax + ", " + AgeMin + ", " + Price + ", " + Condition + ", " + QuantityOfGame + ", " + BeingRepaired;
        }
    }
}
