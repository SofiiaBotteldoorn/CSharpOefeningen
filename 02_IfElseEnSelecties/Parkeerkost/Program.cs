//------------------------------------------------------------------
// Parkeerkost berekening: eerste uur 1,50, daarna per 30 min extra
// Gebruik van if en Math.Ceiling
//------------------------------------------------------------------
Console.WriteLine("Hoeveel minuten heeft u geparkeerd?");
try
{
    int minuten = int.Parse(Console.ReadLine()!);
    while (minuten <= 0)
    {
        Console.WriteLine("Moet positief zijn");
        minuten = int.Parse(Console.ReadLine()!);
    }

    decimal prijs = 1.50m;

    if (minuten > 60)
    {
        int restMinuten = minuten - 60;
        int halveUren = (int)Math.Ceiling(restMinuten / 30.0); //restMinuten ronden naar boven voor volgende 30min prijs
        prijs += halveUren * 0.80m;
    }
    Console.WriteLine($"Te betalen bedrag: {prijs:0.00} euro");
}
catch(Exception ex)
{
    Console.WriteLine("Je typt geen getal. Controleer uw invoer");
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
}
