using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Resources;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Genspil15
{
    // enum GenreOfGame // Vi kan bruge enum Genre til at sikre at man ikke skriver fx: strategi og strategispil
    //{
    //Strategi, Chance, Rollespil, Skak,
    //}
public enum Condition
	{
		HeltNy = 1,
		GodStand = 2,
		LettereRidset = 3,
		TilRep = 4,
		KanMåskeReddes = 5,
        MåskePåVej = 6
	};

    public enum Genre
    {
		Ukendt,
        Strategi,
		Party,
		DeckBuilding,
		Cooperative,
		TilePlacement,
		Deduction,
		WorkerPlacement,
		Adventure,
		Abstract,
		WordPuzzle
	}
    
    public class Game
    {
        public string GameName { get; set; } = "ukendt";
        public string GameEdition { get; set; } = "ukendt";
        public Genre Genre { get; set; } = Genre.Ukendt;
        public int NumberOfPlayersMin { get; set; } = 0;
        public int NumberOfPlayersMax { get; set; } = 0;
        public int AgeMin { get; set; } = 0;
        public double Price { get; set; } = 0;
        public Condition Condition { get; set; } = Condition.HeltNy;
        public int QuantityOfGame { get; set; } = 0;
        public string Waitlist { get; set; } = " ";
        public bool Reserved { get; set; } = false;
        public bool BeingRepaired { get; set; } = false;

        public Game() 
        { 
            //Tom Constructor
        }

        public Game(string gameName, string gameEdition, Genre genre, int numberOfPlayersMin, int numberOfPlayersMax, int ageMin, double price, Condition condition, int quantityOfGame, bool reserved, string waitlist)
        {
            GameName = gameName;
            GameEdition = gameEdition;
            Genre = genre;
            NumberOfPlayersMin = numberOfPlayersMin;
            NumberOfPlayersMax = numberOfPlayersMax;
            AgeMin = ageMin;
            Price = price;
            Condition = condition;
            QuantityOfGame = quantityOfGame;
            Reserved = reserved;
            Waitlist = waitlist;
        }

        public string CreateGame()
        {
            Console.WriteLine("Har du lavet en søgning om spillet allerede lægger i dataen og er sikker på at den ikke eksistere? y eller n");
            Console.WriteLine("Hvis y, så får du muligheden for at tilføje spillet.");
            string SearchedForGame = Console.ReadLine();
            if (SearchedForGame == "y")
            {
                Console.WriteLine("Hvad er navnet?");
                GameName = Console.ReadLine();

                Console.WriteLine("Hvad er versionen/edition? (Hvis ingen, tryk enter...)");
                GameEdition = Console.ReadLine();

                Console.WriteLine("Hvad er genren?");
                Console.WriteLine("0. Ukendt\n1. Strategi\n2.Party\n3.Deckbuilding\n4. Cooperative\n5. TilePlacement\n6. Deduction\n7. WorkerPlacement\n8. Adventure\n9. Abstract\n10. WordPuzzle");

                Genre = (Genre)int.Parse(Console.ReadLine());

                Console.WriteLine("Hvad er det mindst mulige antalspillere?");
                NumberOfPlayersMin = int.Parse(Console.ReadLine());

                Console.WriteLine("Hvad er det størst mulige antalspillere?");
                NumberOfPlayersMax = int.Parse(Console.ReadLine());

                Console.WriteLine("Hvad er aldersgrænsen?");
                AgeMin = int.Parse(Console.ReadLine());

                Console.WriteLine("Hvad er prisen?");
                Price = double.Parse(Console.ReadLine());

                Console.WriteLine("Hvad er tilstanden på spillet?\n1. HeltNy / IkkeÅbnet\n2. OkStand / GodStand\n3. Lettere ridset / Skadet på hjørnet ellers fin stand / Lidt slidt / Lidt skrammet\n4. Til rep\n5. Kan måske reddes\n6. På vej/måske på vej");
                Condition = (Condition)int.Parse(Console.ReadLine());

                Console.WriteLine("Hvor mange spil er der som dette? 0, 1 eller flere? skriv et tal:");
                QuantityOfGame = int.Parse(Console.ReadLine());

                if (QuantityOfGame == 0)
                {
                    Console.WriteLine("Skal der laves en reservation på produktet? y eller n");
                    string yayornay = Console.ReadLine();

                    if (yayornay == "y")
                    {
                        Reserved = true;
                        Console.WriteLine("Hvilket navn skal reservationen stå under?");
                        Waitlist = Console.ReadLine();
                    }
                    else
                    {
                        Reserved = false;
                        Waitlist = " ";
                    }
                }

                Reserved = false;
                Waitlist = " ";


                Console.WriteLine("Du har oprettet følgende spil:");
                Console.WriteLine(MakeTitle());
            }   
                return MakeTitle();
            
        }

        public string MakeTitle()
        {
            return GameName + "," + GameEdition + "," + Genre + "," + NumberOfPlayersMin + "," + NumberOfPlayersMax + "," + AgeMin + "," + Price + "," + Condition + "," + QuantityOfGame + "," + Reserved;
        }
    }
}
