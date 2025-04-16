using DelegatesEnLambdas;
using DelegatesEnLambdas.Services;

//Begroeting gebruiker. Multicast delegate
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Uw naam:");

Begroeting melding = DelegateTypes.ToonWelkom;
melding += DelegateTypes.ToonDatum;
melding += DelegateTypes.ToonTijd;
melding();

//Array met getallen creeren 
int aantalGetallen = InvoerService.VraagGetallen();
int[] getallen = InvoerService.ArrayGetallenInvullen(aantalGetallen);


//MENU
while (true)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("---MENU---");
    Console.WriteLine("1. Positieve getallen tonen");
    Console.WriteLine("2. Even getallen tonen");
    Console.WriteLine("3. Oneven getallen tonen");
    Console.WriteLine("4. Som berekenen");
    Console.WriteLine("5. Kwadraat berekenen");
    Console.WriteLine("6. Halveer getallen");
    Console.WriteLine("7. Absolute waarden tonen");
    Console.WriteLine("8. Getallen tussen 10 en 50");
    Console.WriteLine("9. Input naar hoofdletters");
    Console.WriteLine("10. Input omgekeerd tonen");
    Console.WriteLine("0. Afsluiten");
    Console.Write("Kies een optie: ");

    string keuze = Console.ReadLine()!;
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.Yellow;
    switch (keuze)
    {
        case "1":
            Console.WriteLine("Positieve:");
            GetalFilter isPositief = getal => getal > 0;
            DelegateTypes.ToonGetallen(isPositief, getallen);
            break;
        case "2":
            Console.WriteLine("Even");
            GetalFilter isEven = getal => getal % 2 == 0;
            DelegateTypes.ToonGetallen(isEven, getallen);
            break;
        case "3":
            Console.WriteLine("Oneven");
            DelegateTypes.ToonGetallen((getal => getal % 2 != 0), getallen);
            break;
        case "4":
            Console.WriteLine("SOM");
            Func<int, int, int> totaal = (getal1, getal2) => getal1 + getal2;
            DelegateTypes.ToonSom(totaal, getallen);
            break;
        case "5":
            Console.WriteLine("Kwadraat");
            Bewerking kwadraat = getal => getal * getal;
            DelegateTypes.ToonGetallen(kwadraat, getallen);
            break;
        case "6":
            Console.WriteLine("Halveren");
            Bewerking halveren = getal => getal / 2;
            DelegateTypes.ToonGetallen(halveren, getallen);
            break;
        case "7":
            Console.WriteLine("Absoluut");
            Action<int> absoluut = getal => Console.WriteLine(Math.Abs(getal));
            DelegateTypes.ToonGetallen(absoluut, getallen);
            break;
        case "8":
            Console.WriteLine("Getallen tussen 10 en 50");
            Action<int> tussen10En50 = getal =>
            {
                if (getal > 10 && getal < 50)
                {
                    Console.WriteLine(getal);
                }
            };
            DelegateTypes.ToonGetallen(tussen10En50, getallen);
            break;
        case "9":
            Console.WriteLine("Input naar hoofdletters");
            TransformeerTekst naarHoofdletters = (tekst) => tekst.ToUpper();
            Console.WriteLine(naarHoofdletters(Console.ReadLine()));
            break;
        case "10":
            Console.WriteLine("Reverse");
            TransformeerTekst reverse = (tekst) => new string(tekst.Reverse().ToArray());
            Console.WriteLine(reverse(Console.ReadLine()));
            break;
        case "0":
            Console.WriteLine("Tot ziens!");
            return;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ongeldige keuze");
            break;
    };
}


