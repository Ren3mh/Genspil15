﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Genspil15
{
    class MainMenu
    {

        public string FileName { get; set; } = "LagerListe.txt"; //Navn på test fil til at indlæse fra listen
        //public List<Game> Games { get; set; } = games;

        public List<Game> Games = Filehandler.ReadGamesFromFile("LagerListe.txt");

        public List<Game> SearchList { get; set; } = new List<Game>();
        public Game Game { get; set; } = new Game();
        public string fileName2 { get; set; } = "LagerListe2.txt"; //Navn på den fil der skal gemmes af WriteGames to file

        public MainMenu(string fileName, List<Game> games) 
        {
            FileName = fileName;
            Games = games;
  
        }



        public bool Menu()
        {
            Console.Clear();
            Console.WriteLine("Velkommen til Genspils database-system 0.1 - Hvad vil du gerne?:");
            Console.WriteLine("1) Tilføje et spil");
            Console.WriteLine("2) Søge efter et spil");
            Console.WriteLine("3) Organisere og Printe lagerlisten");
            Console.WriteLine("4) Exit");
            Console.Write("\r\nVælg en mulighed og tryk enter: ");

            switch (Console.ReadLine())
            {
                case "1":
                    var cont = "y";
                    while (cont == "y")
                    {
                    
                    
                    Game.CreateGame();//Kalder createGame metoden som bruges til at oprette et nyt spil i databasen
                    Games.Add(Game); //Tilføjer det nyoprettede game til games listen
                    Console.WriteLine("Vil du tilføje endnu et spil? y eller n fulgt af Enter...");
                    cont = Console.ReadLine();
                        // for at undgå at miste data, så gemmer vi tilføjelserne efter hver.
                        Filehandler.WriteGamesToFile(Games, FileName);
                    }
                        return true;
                case "2":
                    var cont2 = "y";
                    while (cont2 == "y")
                    {
                        List<Game> SearchList = Lager.Search(Games);
						SearchList.Sort((x, y) => x.GameName.CompareTo(y.GameName) + x.GameEdition.CompareTo(y.GameEdition) + y.QuantityOfGame.CompareTo(x.QuantityOfGame));

						Console.WriteLine("Liste over søgning");
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("Navn,\t\t\tUdgave,\t\tGenre,\t\tMin,\tMaks,\tPrice,\tTilstand,\tAntal på lager,\tTil rep.\n");
                        
						foreach (Game game in SearchList)
                        {
                            Console.WriteLine($"{game.GameName}, \t{game.GameEdition}, \t{game.Genre}, \t{game.NumberOfPlayersMin}, \t{game.NumberOfPlayersMax}, \t{game.Price}, \t{game.Condition}, \t{game.QuantityOfGame}, \t\t{game.BeingRepaired}");
                        }
                        Console.WriteLine("\nVil du søge efter endnu et spil? y eller n fulgt af Enter...");
                        cont2 = Console.ReadLine();
                    }
                    return true;


                   
                case "3":
                    Console.WriteLine("Denne funktion er endnu ikke implementeret");
                    return true;
                case "4":

                    return false;
                default:
                    return true;
            }
            

            
        }
        
    }
}
