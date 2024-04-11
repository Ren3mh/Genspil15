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
					string searchGenre = Console.ReadLine();
					return SearchGenre(games, searchGenre);

				case "3":
					Console.WriteLine($"Hvilket navn søger du efter?");
					string svar = Console.ReadLine();
					return SearchName(games, svar);

				case "4":
					Console.WriteLine($"Hvilket prisleje skal spillet ligge under?");
					double searchPrice = double.Parse(Console.ReadLine());
					return SearchPrice(games, searchPrice);

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
			Console.WriteLine("Hvilket spil navn vil du søge efter?");
			string SearchInput = Console.ReadLine();
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
		public static List<Game> SearchGenre(List<Game> games, string searchGenre)
		{
			Console.WriteLine("Hvilken spil genre vil du søge efter?");
			string SearchInput = Console.ReadLine();
			int a = 0;

			List<Game> SearchList = new List<Game>();
			while (a == 0)
			{
				SearchList = games.Where(Game => Game.Genre == SearchInput).ToList();
				SearchList.Sort((x, y) => x.GameName.CompareTo(y.GameName) + x.GameEdition.CompareTo(y.GameEdition) + y.QuantityOfGame.CompareTo(x.QuantityOfGame));
				a = SearchList.Count;
				if (a == 0)
				{
					Console.WriteLine("Ingen spil er fundet med den genre, prøv igen");
					SearchInput = Console.ReadLine();
				}
				else
					return SearchList;
			}
			return SearchList;
		}
		public static List<Game> SearchPrice(List<Game> games, double searchPrice)
		{
			Console.WriteLine("Hvilket prisleje har vi med at gøre idag?");
			double SearchInput = double.Parse(Console.ReadLine());
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
			Console.WriteLine("Hvilken stand må spillet som minimum være i?");
			int SearchInput = int.Parse(Console.ReadLine());
			int a = 0;

			List<Game> SearchList = new List<Game>();
			while (a == 0)
			{
				SearchList = games.Where(Game => Game.Condition == SearchInput).ToList();
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
			Console.WriteLine("Hvor mange spillere skal der minimum kunne spille?");
			int SearchInput = int.Parse(Console.ReadLine());
			int a = 0;

			List<Game> SearchList = new List<Game>();
			while (a == 0)
			{
				SearchList = games.Where(Game => Game.NumberOfPlayersMin >= SearchInput && Game.NumberOfPlayersMax <= SearchInput).ToList();
				SearchList.Sort((x, y) => x.GameName.CompareTo(y.GameName) + x.GameEdition.CompareTo(y.GameEdition) + y.QuantityOfGame.CompareTo(x.QuantityOfGame));
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
			Console.WriteLine("Hvor mange spillere skal der maksimum kunne spille?");
			int SearchInput = int.Parse(Console.ReadLine());
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

	}
}
