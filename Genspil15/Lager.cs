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
			Console.WriteLine("Hvilket spil navn vil du søge efter?");
			string Søg = Console.ReadLine();

			var SøgningNavn = games.Where(Game => Game.GameName == Søg).ToList();
			// IEnumerable<Game> SøgningNavn = games.FindAll(s => Søg == GameName);

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
