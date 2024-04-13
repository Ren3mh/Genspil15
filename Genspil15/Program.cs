
namespace Genspil15
{
    public class Program
    {
        static void Main(string[] args)
        {
            string fileName = "LagerListe.txt";
			List<Game> games = Filehandler.ReadGamesFromFile(fileName); //Laver en liste "games" af Game objecter
			
            MainMenu menu = new MainMenu(fileName, games);

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = menu.Menu();
            }

            

            
            Console.WriteLine("Tak for nu...");
            Console.ReadLine();
        }
    }
}
