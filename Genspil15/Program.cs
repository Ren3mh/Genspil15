
namespace Genspil15
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD

            //Game game = new Game();
            //game.CreateGame(); //Kalder createGame metoden som bruges til at oprette et nyt spil i databasen
            //List<Game> games = new List<Game>(); //Laver en liste "games" af Game objecter
            //games.Add(game); //Tilføjer det nyoprettede game til games listen




            string fileName = "sequence.txt"; //Navn på test fil til at indlæse fra listen
=======
            List<Game> games = new List<Game>(); //Laver en liste "games" af Game objecter
            Game game = new Game();

            var cont = "y";
            while (cont == "y")
            {
                game.CreateGame(); //Kalder createGame metoden som bruges til at oprette et nyt spil i databasen
                games.Add(game); //Tilføjer det nyoprettede game til games listen
                Console.WriteLine("Vil du tilføje endnu et spil? y eller n fulgt af Enter...");
                cont = Console.ReadLine();
            }
                
           
            
            //string fileName = "sequence.txt"; //Navn på test fil til at indlæse fra listen
>>>>>>> 2e815175b9b19fd1596a59a043d3e0cff20afe87

            List<Game> games = Filehandler.ReadGamesFromFile(fileName); //Læser testfilen og laver et liste object
			//Game game = new Game();
			//game.CreateGame();
			//games.Add(game);

			////SorteringsAlgoritmer.BubbleSort(games); //Udkommenteret

			string fileName2 = "SavedGamesList.txt"; //Navn på den fil der skal gemmes af WriteGames to file

            Filehandler.WriteGamesToFile(games, fileName2); //tager listen games og filnavnet fileName2 og skriver listen til filen

            Console.WriteLine("Tak for nu...");
            Console.ReadLine();
        }
    }
}
