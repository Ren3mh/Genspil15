using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genspil15
{
	class SearchResult
	{
		public List<Game> gamesFound;

		//public double price(Game price)
		//{

		//}
	}
	public class Lager
	{

		public static List<Game> Search(List<Game> games)
		{
			Console.WriteLine("Hvilket spil navn vil du søge efter Troels?");
			string Søg = Console.ReadLine();
			int a = 0;
			List<Game> SøgningNavn = new List<Game>();
			// var SøgningNavn = games.Where(Game => Game.GameName == Søg).ToList();
			// IEnumerable<Game> SøgningNavn = games.FindAll(s => Søg == GameName);
			while (a == 0)
			{
				SøgningNavn = games.Where(Game => Game.GameName == Søg).ToList();
				a = SøgningNavn.Count;
				if (a == 0)
				{
					Console.WriteLine("Ingen spil er fundet med det navn, prøv igen");
					Søg = Console.ReadLine();
				}
				else
					return SøgningNavn;
			}
			return SøgningNavn;
			//SearchResult sr = new SearchResult();
			//foreach (Game g in games)
			//{
			//	if (g.GameName == GameName)
			//		return g;
			//	return -1;
			//}
		}
	}
}
