using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*class Spil
{
    public string Navn { get; set; }
    public int Antal { get; set; }
    public string Stand { get; set; }

    public Spil(string navn, int antal, string stand)
    {
        Navn = navn;
        Antal = antal;
        Stand = stand;
    }
}


class Program
{

    static void TilføjSpil(Dictionary<string, List<Spil>> lagerliste, string genre, string navn, int antal, string stand)
    {
        if (!lagerliste.ContainsKey(genre))
        {
            lagerliste.Add(genre, new List<Spil>());
        }
        lagerliste[genre].Add(new Spil(navn, antal, stand));
    }

    static void Main()
    {
        // En organiseret lagerliste af spil fordelt på genre
        Dictionary<string, List<Spil>> lagerliste = new Dictionary<string, List<Spil>>();

        // Her bliver spillene tilføjet til lagerlisten. Inklusiv genre, stand og titler. 
        // Man kan altid tilføje flere. De er tilføjet manuelt, da jeg ikke kunne få den til at læse fra en fil. 
        TilføjSpil(lagerliste, "Kids", "Original", 2, "God");
        TilføjSpil(lagerliste, "Kids", "Junior", 1, "Lidt skrammet");
        TilføjSpil(lagerliste, "Kids", "Giant", 2, "God");

        TilføjSpil(lagerliste, "Rejsespil", "Berlin, Ticket To Ride", 3, "2 God, 1 til reparation");
        TilføjSpil(lagerliste, "Rejsespil", "Europe - engelsk", 0, "Ukendt");
        TilføjSpil(lagerliste, "Rejsespil", "Europe - dansk", 2, "God");
        TilføjSpil(lagerliste, "Rejsespil", "Europa - 1912", 0, "Ukendt");
        TilføjSpil(lagerliste, "Rejsespil", "Europe - engelsk", 0, "Ukendt");
        TilføjSpil(lagerliste, "Rejsespil", "First journey", 1, "God");
        TilføjSpil(lagerliste, "Rejsespil", "Ghost train", 0, "God");
        TilføjSpil(lagerliste, "Rejsespil", "Northern lights", 0, "Ukendt");
        TilføjSpil(lagerliste, "Rejsespil", "2nd edition cities", 1, "Dårlig");


        TilføjSpil(lagerliste, "Strategi", "Dansk 2nd edition", 1, "God");
        TilføjSpil(lagerliste, "Strategi", "Architects - dansk", 3, "2 God, 1 Uåbnet");
        TilføjSpil(lagerliste, "Strategi", "Architects - medals", 1, "Dårlig");
        TilføjSpil(lagerliste, "Strategi", "Dansk duel - Agora", 3, "1 God, 2 Uåbnet");
        TilføjSpil(lagerliste, "Strategi", "Duel - Agora - Engelsk", 1, "Dårlig");


        // Her printes lagerlisten af spil fordelt på genre
        // Genrene udskrives med deres tilhørende spil 
        Console.WriteLine("Lagerliste:");
        foreach (var genre in lagerliste)
        {
            Console.WriteLine($"Genre: {genre.Key}");
            foreach (var spil in genre.Value)
            {
                Console.WriteLine($"- Spil: {spil.Navn}, Antal: {spil.Antal}, Stand: {spil.Stand}");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }

*/