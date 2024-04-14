
namespace Genspil15
{
    public class Program
    {
        static void Main(string[] args)
        {
			Console.SetWindowSize(130, 40);
			string nuvDir = Directory.GetCurrentDirectory();
            
            string dir2 = Directory.GetParent(nuvDir).FullName;
            
            string dir1 = Directory.GetParent(dir2).FullName;
           
            string dir = Directory.GetParent(dir1).FullName;
            
            string dirMappe = Directory.GetParent(dir).FullName;
            

            string fileName = "LagerListe.txt";
            string filePath = Path.Combine(dirMappe, fileName);
			List<Game> games = Filehandler.ReadGamesFromFile(filePath); //Laver en liste "games" af Game objecter
			
            MainMenu menu = new MainMenu(filePath, games, dirMappe);

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
