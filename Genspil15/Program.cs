
namespace Genspil15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game();
            game.CreateGame(); //Kalder createGame metoden som bruges til at oprette et nyt spil i databasen
           

            string fileName = "sequence.txt"; //Navn på test fil til at indlæse fra listen

            List<Game> games = Filehandler.ReadGamesFromFile(fileName); //Læser testfilen og laver et liste object



            //SorteringsAlgoritmer.BubbleSort(games); //Udkommenteret

            string fileName2 = "SavedGamesList.txt"; //Navn på den fil der skal gemmes af WriteGames to file

            Filehandler.WriteGamesToFile(games, fileName2);

            Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }
    }
}
