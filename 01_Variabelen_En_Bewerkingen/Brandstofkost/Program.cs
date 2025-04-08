//------------------------------------------------
// Brandstofkost
// Constante verbruik + brandstofprijs + input km
//------------------------------------------------

const decimal Verbruik = 6.5m; //liters per 100km
const decimal BrandstofPrijs = 1.72m; //euros per 1l
Console.WriteLine("Hoeveel kilometers uw rit is?");
if (decimal.TryParse(Console.ReadLine(), out decimal kilometrage))
{
    decimal litersPer1Km = Verbruik / 100m;
    decimal hoeveelPerRit = litersPer1Km * kilometrage;
    decimal prijsPerRit = hoeveelPerRit * BrandstofPrijs;
    Console.WriteLine($"Uw rit kost {prijsPerRit:0.00} euro");

    // of:
    //Console.WriteLine($"Uw rit kost {(kilometrage * Verbruik / 100 * BrandstofPrijs):0.00} euro");
}
else
{
    Console.WriteLine("Verkeerde gegevens");
}