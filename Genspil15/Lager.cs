using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genspil15
{
	class Lager
	{

		public static List<Game> Search(List<Game> games)
		{
			//Console.WriteLine("Vil du søge efter et spil ? y/n");
			//string svar = Console.ReadLine();
			//while (svar == "y")
				Console.Clear();
				Console.WriteLine("Hvilket filter vil du søge efter?");
				Console.WriteLine("1. Name \n2. Genre \n3. Pris \n4. Tilstand\n5. Minimun spillere \n6. Maksimum spillere");
				string SearchFilter = Console.ReadLine();
			
			switch (SearchFilter)
			{
				case "1":
					Console.WriteLine($"Hvilket navn søger du efter?");
					string searchName = Console.ReadLine();
					return SearchName(games, searchName);

				case "2":
					Console.WriteLine($"Hvilken genre søger du efter?");
					Console.WriteLine("0. Ukendt\n1. Strategi\n2.Party\n3.Deckbuilding\n4. Quiz\n5. Cooperative\n6. TilePlacement\n7. Deduction\n8. WorkerPlacement\n9. Adventure\n10. Abstract\n11. WordPuzzle");
					int searchGenre = int.Parse(Console.ReadLine());
					return SearchGenre(games, searchGenre);

				case "3":
					Console.WriteLine($"Hvilket prisleje skal spillet ligge under?");
					double searchPrice = double.Parse(Console.ReadLine());
					return SearchPrice(games, searchPrice);

				case "4":
					Console.WriteLine($"Hvilken tilstand skal spillet som minimum have?");
					Console.WriteLine("1. HeltNy / IkkeÅbnet\n2. OkStand / GodStand\n3. Lettere ridset / Skadet på hjørnet ellers fin stand / Lidt slidt / Lidt skrammet\n4. Til rep\n5. Kan måske reddes");
					int searchCondition = int.Parse(Console.ReadLine());
					return SearchCondition(games, searchCondition);

				case "5":
					Console.WriteLine($"Hvor mange skal minimum kunne spille?");
					int searchPlayerMin = int.Parse(Console.ReadLine());
					return SearchPlayerMin(games, searchPlayerMin);

				case "6":
					Console.WriteLine($"Hvor mange skal maksimum kunne spille?");
					int searchPlayerMax = int.Parse(Console.ReadLine());
					return SearchPlayerMax(games, searchPlayerMax);
				default:
					return games;
			}
		}	
		public static List<Game> SearchName(List<Game> games, string searchName)
		{
			string SearchInput = searchName;
			int a = 0;

			List<Game> SearchList = new List<Game>();
			// var SøgningNavn = games.Where(Game => Game.GameName == Søg).ToList();
			// IEnumerable<Game> SøgningNavn = games.FindAll(s => Søg == GameName);
			while (a == 0)
			{
				SearchList = games.Where(Game => Game.GameName == SearchInput).ToList();
				SearchList.Sort((x, y) => x.GameName.CompareTo(y.GameName) + x.GameEdition.CompareTo(y.GameEdition) + y.QuantityOfGame.CompareTo(x.QuantityOfGame));
				a = SearchList.Count;
				if (a == 0)
				{
					Console.WriteLine("Ingen spil er fundet med det navn, prøv igen");
					SearchInput = Console.ReadLine();
				}
				else
					return SearchList;
			}
			return SearchList;
		}
		public static List<Game> SearchGenre(List<Game> games, int searchGenre)
		{
			int SearchInput = searchGenre;
			int a = 0;

			List<Game> SearchList = new List<Game>();
			while (a == 0)
			{
				SearchList = games.Where(Game => (int)Game.Genre == SearchInput).ToList();
				SearchList.Sort((x, y) => x.GameName.CompareTo(y.GameName) | x.GameEdition.CompareTo(y.GameEdition));
				a = SearchList.Count;
				if (a == 0)
				{
					Console.WriteLine("Ingen spil er fundet med den genre, prøv igen");
					SearchInput = int.Parse(Console.ReadLine());
				}
				else
					return SearchList;
			}
			return SearchList;
		}
		public static List<Game> SearchPrice(List<Game> games, double searchPrice)
		{
			double SearchInput = searchPrice;
			int a = 0;

			List<Game> SearchList = new List<Game>();
			while (a == 0)
			{
				SearchList = games.Where(Game => Game.Price >= SearchInput).ToList();
				SearchList.Sort((x, y) => x.GameName.CompareTo(y.GameName) + x.GameEdition.CompareTo(y.GameEdition) + y.QuantityOfGame.CompareTo(x.QuantityOfGame));
				a = SearchList.Count;
				if (a == 0)
				{
					Console.WriteLine("Ingen spil er fundet med det prisleje, prøv igen");
					SearchInput = double.Parse(Console.ReadLine());
				}
				else
					return SearchList;
			}
			return SearchList;
		}
		public static List<Game> SearchCondition(List<Game> games, int searchCondition)
		{
			int SearchInput = searchCondition;
			int a = 0;

			List<Game> SearchList = new List<Game>();
			while (a == 0)
			{
				SearchList = games.Where(Game => (int)Game.Condition <= SearchInput).ToList();
				SearchList.Sort((x, y) => x.GameName.CompareTo(y.GameName) + x.GameEdition.CompareTo(y.GameEdition) + y.QuantityOfGame.CompareTo(x.QuantityOfGame));
				a = SearchList.Count;
				if (a == 0)
				{
					Console.WriteLine("Ingen spil er fundet med minimum standen eller over, prøv igen");
					SearchInput = int.Parse(Console.ReadLine());
				}
				else
					return SearchList;
			}
			return SearchList;
		}
		public static List<Game> SearchPlayerMin(List<Game> games, int searchPlayerMin)
		{
			int SearchInput = searchPlayerMin;
			int a = 0;

			List<Game> SearchList = new List<Game>();
			while (a == 0)
			{
				SearchList = games.Where(Game => Game.NumberOfPlayersMin == SearchInput).ToList();
				SearchList.Sort((x, y) => x.GameName.CompareTo(y.GameName) | x.GameEdition.CompareTo(y.GameEdition));
				a = SearchList.Count;
				if (a == 0)
				{
					Console.WriteLine("Ingen spil er fundet med det minimum, prøv igen");
					SearchInput = int.Parse(Console.ReadLine());
				}
				else
					return SearchList;
			}
			return SearchList;
		}
		public static List<Game> SearchPlayerMax(List<Game> games, int searchPlayerMax)
		{
			int SearchInput = searchPlayerMax;
			int a = 0;

			List<Game> SearchList = new List<Game>();
			while (a == 0)
			{
				SearchList = games.Where(Game => Game.NumberOfPlayersMax == SearchInput).ToList();
				SearchList.Sort((x, y) => x.GameName.CompareTo(y.GameName) + x.GameEdition.CompareTo(y.GameEdition) + y.QuantityOfGame.CompareTo(x.QuantityOfGame));
				a = SearchList.Count;
				if (a == 0)
				{
					Console.WriteLine("Ingen spil er fundet med det maksimum, prøv igen");
					SearchInput = int.Parse(Console.ReadLine());
				}
				else
					return SearchList;
			}
			return SearchList;
		}
		public static List<Game> OnStorageItems(List<Game> games)
		{
			int a = 0;

			List<Game> StorageList = new List<Game>();
			while (a == 0)
			{
				StorageList = games.Where(Game => Game.QuantityOfGame >= 1).ToList();
				StorageList.Sort((x, y) => x.GameName.CompareTo(y.GameName) + x.GameEdition.CompareTo(y.GameEdition) + y.QuantityOfGame.CompareTo(x.QuantityOfGame));
				a = StorageList.Count;
				if (a == 0)
				{
					Console.WriteLine("I har intet på Lager, anskaf jer nogle varer først");
				}
				else
					return StorageList;
			}
			return StorageList;
		}

	}
}
