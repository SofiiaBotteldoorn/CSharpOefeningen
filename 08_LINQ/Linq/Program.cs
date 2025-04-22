using Linq;

var boeken = BoekService.BoekenLijst();
while (true)
{
    Console.ForegroundColor = ConsoleColor.Green;
    //Menu
    Console.WriteLine("\n--- MENU ---");
    Console.WriteLine("1. Toon boeken onder 15 euro");
    Console.WriteLine("2. Toon aantal boeken per genre");
    Console.WriteLine("3. Toon gemiddelde prijs van alle boeken");
    Console.WriteLine("4. Toon gemiddelde en hoogste prijs van romans");
    Console.WriteLine("5. Toon boeken > 500 pagina's");
    Console.WriteLine("6. Toon boeken die starten met T");
    Console.WriteLine("7. Toon unieke genres");
    Console.WriteLine("8. Toon boeken per genre met statistieken");
    Console.WriteLine("9. Toon duurste boek per genre");
    Console.WriteLine("10. Toon boeken alfabetisch op auteurs naam");
    Console.WriteLine("11. Toon boeken per genre, gesorteerd op prijs dalend");
    Console.WriteLine("0. Stop");
    Console.WriteLine();

    Console.WriteLine("Uw keuze:");
    string keuze = Console.ReadLine()!;

    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    switch (keuze)
    {
         
        case "1":
            BoekService.ToonBoekenOnder15Euro(boeken);
            break;
        case "2":
            BoekService.ToonAantalBoekenPerGenre(boeken);
            break;
        case "3":
            BoekService.ToonGemmideldePrijsVanAlleBoeken(boeken);
            break;
        case "4":
            BoekService.ToonGemmideldeEnHoogstePrijsRoman(boeken);
            break;
        case "5":
            BoekService.ToonBoekenMetMeerDan500Paginas(boeken);
            break;
        case "6":
            BoekService.ToonBoekenDieBeginMetTStarten(boeken);
            break;
        case "7":
            BoekService.ToonUniekeGenres(boeken);
            break;
        case "8":
            BoekService.ToonBoekenPerGenre(boeken);
                break;
        case "9":
            BoekService.ToonDuursteBoekenPerGenre(boeken);
            break;
        case "10":
            BoekService.ToonBoekenOpAuteursNaam(boeken);
            break;
        case "11":
            BoekService.ToonBoekenPerGenreOpPrijs(boeken);
            break;
        case "0":
            Console.WriteLine("Tot ziens!");
            return;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Verkeerde invoer. Probeer opnieuw");
            break;
    }
}
