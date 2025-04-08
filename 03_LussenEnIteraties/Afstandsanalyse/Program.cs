//------------------------------
//While-lus, functie, procedure
//------------------------------

double afstand = AfstandVragen();
double totaal = 0;
int aantal = 0;
double kortsteRit = afstand;
double langsteRit = afstand;


while (afstand != -1)
{
    totaal += afstand;
    aantal++;
    if (afstand > langsteRit)
    {
        langsteRit = afstand;
    }
    else if (afstand < kortsteRit)
    {
        kortsteRit = afstand;
    }
    AfstandVragen();
}
if (aantal > 0)
{
    double gemiddeldeGereden = totaal / aantal;
    Console.WriteLine($"Uw kortste rit: {kortsteRit} km. Uw langste rit: {langsteRit} km.");
    Lijn(40, '*');
    Console.WriteLine($"Gemiddelde gereden: {gemiddeldeGereden:0.00} km.");
    Lijn(40, '=');
}
else
{
    Console.WriteLine("Geen riten ingegeven");
    Lijn(40, '=');
}


double AfstandVragen()
{

    Console.WriteLine("Geef uw rit afstand of tik -1 om te stoppen");
    while (true)
    {
        if (double.TryParse(Console.ReadLine(), out afstand))
        {
            if (afstand == -1 || afstand > 0)
            {
                return afstand;
            }
            else if (afstand < -1)
            {
                Console.WriteLine("Onmogelijk. Geef uw rit afstand -1 om te stoppen.");
            }
        }
        else
        {
            Console.WriteLine("Onmogelijk. Geef uw rit afstand of tik -1 om te stoppen");
        }

    }
}

void Lijn(int lengte, char teken = '*')
{
    for (int i = 0; i < lengte; i++)
    {
        Console.Write(teken);
    }
    Console.WriteLine();

}
