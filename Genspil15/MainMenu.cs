using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genspil15
{
    class MainMenu
    {
        static string fileName = "Sequence.txt"; //Navn på test fil til at indlæse fra listen
        List<Game> games = Filehandler.ReadGamesFromFile(fileName); //Læser testfilen og laver et liste object
		List<Game> SearchList = new List<Game>();

		Game game = new Game();


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
                    
                    
                    game.CreateGame();//Kalder createGame metoden som bruges til at oprette et nyt spil i databasen
                    games.Add(game); //Tilføjer det nyoprettede game til games listen
                    Console.WriteLine("Vil du tilføje endnu et spil? y eller n fulgt af Enter...");
                    cont = Console.ReadLine();
                    }
                        return true;
                case "2":
                    var cont2 = "y";
                    while (cont2 == "y")
                    {
                        List<Game> SearchList = Lager.Search(games);
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
