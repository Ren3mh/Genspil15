namespace Genspil15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "sequence.txt";

            List<Game> games = Filehandler.ReadGamesFromFile(fileName);

            string fileName2 = "SavedGamesList.txt";
            //SorteringsAlgoritmer.BubbleSort(games);
            Filehandler.WriteGamesToFile(games, fileName2);

            Console.WriteLine("Hello, World!");
        }
    }
}
