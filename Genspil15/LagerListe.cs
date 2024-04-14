using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*class Bog
{
    public string Navn { get; set; }
    public int Antal { get; set; }
    public string Stand { get; set; }

    public Bog(string navn, int antal, string stand)
    {
        Navn = navn;
        Antal = antal;
        Stand = stand;
    }
}


class Program
{

    static void TilføjBog(Dictionary<string, List<Bog>> lagerliste, string genre, string navn, int antal, string stand)
    {
        if (!lagerliste.ContainsKey(genre))
        {
            lagerliste.Add(genre, new List<Bog>());
        }
        lagerliste[genre].Add(new Bog(navn, antal, stand));
    }

    static void Main()
    {
        // En organiseret lagerliste af bøger fordelt på genre
        Dictionary<string, List<Bog>> lagerliste = new Dictionary<string, List<Bog>>();

        // Her bliver bøgerne tilføjet til lagerlisten. Inklusiv gennre, stand og titler. 
        // Man kan altid tilføje flere. De er tilføjet manuelt, da jeg ikke kunne få den til at læse fra en fil. 
        TilføjBog(lagerliste, "Kids", "Original", 2, "God");
        TilføjBog(lagerliste, "Kids", "Junior", 1, "Lidt skrammet");
        TilføjBog(lagerliste, "Kids", "Giant", 2, "God");

        TilføjBog(lagerliste, "Rejsespil", "Berlin, Ticket To Ride", 3, "2 God, 1 til reparation");
        TilføjBog(lagerliste, "Rejsespil", "Europe - engelsk", 0, "Ukendt");
        TilføjBog(lagerliste, "Rejsespil", "Europe - dansk", 2, "God");
        TilføjBog(lagerliste, "Rejsespil", "Europa - 1912", 0, "Ukendt");
        TilføjBog(lagerliste, "Rejsespil", "Europe - engelsk", 0, "Ukendt");
        TilføjBog(lagerliste, "Rejsespil", "First journey", 1, "God");
        TilføjBog(lagerliste, "Rejsespil", "Ghost train", 0, "God");
        TilføjBog(lagerliste, "Rejsespil", "Northern lights", 0, "Ukendt");
        TilføjBog(lagerliste, "Rejsespil", "2nd edition cities", 1, "Dårlig");


        TilføjBog(lagerliste, "Strategi", "Dansk 2nd edition", 1, "God");
        TilføjBog(lagerliste, "Strategi", "Architects - dansk", 3, "2 God, 1 Uåbnet");
        TilføjBog(lagerliste, "Strategi", "Architects - medals", 1, "Dårlig");
        TilføjBog(lagerliste, "Strategi", "Dansk duel - Agora", 3, "1 God, 2 Uåbnet");
        TilføjBog(lagerliste, "Strategi", "Duel - Agora - Engelsk", 1, "Dårlig");


        // Her printes lagerlisten af bøger fordelt på genre
        // Genrene udskrives med dets tilhørende bøger 
        Console.WriteLine("Lagerliste:");
        foreach (var genre in lagerliste)
        {
            Console.WriteLine($"Genre: {genre.Key}");
            foreach (var bog in genre.Value)
            {
                Console.WriteLine($"- Bog: {bog.Navn}, Antal: {bog.Antal}, Stand: {bog.Stand}");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }


}
*/