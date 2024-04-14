using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Genspil15
{
    class MainMenu
    {

        public string FileName { get; set; } = "LagerListe.txt"; //Navn på test fil til at indlæse fra listen
        //public List<Game> Games { get; set; } = games;

        //public List<Game> Games = Filehandler.ReadGamesFromFile("LagerListe.txt");

        public List<Game> SearchList { get; set; } = new List<Game>();
        public Game Game { get; set; } = new Game();
        public string fileName2 { get; set; } = "LagerListe2.txt"; //Navn på den fil der skal gemmes af WriteGames to file

        public string DirMappe { get; set; }

        public MainMenu(string fileName, List<Game> games, string dirMappe) 
        {
            FileName = fileName;
            DirMappe = dirMappe;
            //Games = games;
  
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

			List<Game> Games = Filehandler.ReadGamesFromFile(FileName);
            




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
                        Console.Clear();
                    }
                        return true;

                case "2":
                    string cont2 = "y";
                    while (cont2 == "y")
                    {
                        // List<Game> Games = Filehandler.ReadGamesFromFile("LagerListe.txt");
                        List<Game> SearchList = Lager.Search(Games);
                        SearchList.Sort((x, y) => x.GameName.CompareTo(y.GameName) + x.GameEdition.CompareTo(y.GameEdition) + y.QuantityOfGame.CompareTo(x.QuantityOfGame));

                        Console.WriteLine("Liste over søgning");
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("Navn,\t\t\tUdgave,\t\tGenre,\t\tMin,\tMaks,\tPrice,\tTilstand,\tAntal på lager,\tTil rep.\n");

                        int i = 0;
                        foreach (Game game in SearchList)
                        {
                            Console.WriteLine($"{i}-{game.GameName}, \t{game.GameEdition}, \t{game.Genre}, \t{game.NumberOfPlayersMin}, \t{game.NumberOfPlayersMax}, \t{game.Price}, \t{game.Condition}, \t{game.QuantityOfGame}, \t\t{game.BeingRepaired}");
                            i++;
                        }
                        Console.WriteLine("\nVil du søge efter endnu et spil? 'y'/'n' \nEller 's': sælge et spil, fulgt af Enter...");
                        cont2 = Console.ReadLine();
                        if (cont2 == "s")
                        {
                            Console.WriteLine("Skriv nummeret på det spil du vil sælge og tryk enter...");
                            int indexValgInt = int.Parse(Console.ReadLine());
                            if (indexValgInt >= 0)
                            {
                                var spilValgtVar = SearchList[indexValgInt]; //

                                int indexResultat = Games.IndexOf(spilValgtVar);

                                Games[indexResultat].QuantityOfGame = Games[indexResultat].QuantityOfGame - 1;

                                Console.WriteLine("Antallet af valgte spil er nu: {0}", Games[indexResultat].QuantityOfGame);
                                Filehandler.WriteGamesToFile(Games, FileName);
                                Console.WriteLine("Gemmer listen på computeren og returnerer til menuen");
                                Console.WriteLine("3");
                                Thread.Sleep(1000); // 3000 milliseconds = 3 seconds
                                Console.WriteLine("2");
                                Thread.Sleep(1000); // 3000 milliseconds = 3 seconds
                                Console.WriteLine("1");
                                Thread.Sleep(1000); // 3000 milliseconds = 3 seconds

                                //Games.FindIndex(SearchList[indexValgInt]);
                                //1: sæt valgte game fra search list til en VAR
                                //2: søg og find VAR på games listen
                                //3: reducer Quantity med -1
                                //4: gem ændret games liste }


                            }
                        }

                    }
                        return true;


                case "3":
                    var cont3 = "y";
                    while (cont3 == "y")
                    {
						// List<Game> Games = Filehandler.ReadGamesFromFile("LagerListe.txt");
						List<Game> StorageList = Lager.OnStorageItems(Games);
                        DateTime currentTime= DateTime.Now;
                        String FileNameStatus = Path.Combine(DirMappe + $"\\Lagerliste{currentTime.ToShortDateString()}.txt");
                        
                        Console.WriteLine("Liste over varer som er på lager");
                        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
                        Console.WriteLine("Navn,\t\t\tUdgave,\t\tGenre,\t\tMin,\tMaks,\tPrice,\tTilstand,\tAntal på lager,\tTil rep.\n");

                        foreach (Game game in StorageList)
                        {
                            Console.WriteLine($"{game.GameName}, \t{game.GameEdition}, \t{game.Genre}, \t{game.NumberOfPlayersMin}, \t{game.NumberOfPlayersMax}, \t{game.Price}, \t{game.Condition}, \t{game.QuantityOfGame}, \t\t{game.BeingRepaired}");
                        }
						Console.WriteLine("\nVil du gemme listen til udprint? y eller n fulgt af Enter...");
						string contSave = Console.ReadLine();
						if (contSave == "y")
						{
							Filehandler.WriteGamesToFile(StorageList, FileNameStatus);
							Console.WriteLine("Gemmer listen på computeren og returnerer til menuen");
							Console.WriteLine("3");
							Thread.Sleep(1000); // 3000 milliseconds = 3 seconds
							Console.WriteLine("2");
							Thread.Sleep(1000); // 3000 milliseconds = 3 seconds
							Console.WriteLine("1");
							Thread.Sleep(1000); // 3000 milliseconds = 3 seconds

							cont3 = "n";
						}
						else if (contSave == "n")
						{
							cont3 = contSave;
						}
					}
                    return true;

                

                case "4":

                    return false;
                default:
                    return true;
            }
            

            
        }
        
    }
}
