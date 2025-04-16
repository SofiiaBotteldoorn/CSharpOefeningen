//---------------------------------------------
//Tweedimensionaal array
//Toont hoogste, laagste en gemmidelde punten
//Loops, ifs, functies, procedures
//---------------------------------------------

Console.WriteLine("Hoeveel leerlingen?");
int aantalLeerlingen = int.Parse(Console.ReadLine());
int[,] punten = new int[aantalLeerlingen, 3];

for (int leerling = 1; leerling <= aantalLeerlingen; leerling++)
{
    Console.WriteLine($"Puntenten van leerling nummer {leerling}");

    Console.WriteLine("Punten Solfege");
    int puntenSolfege = LeesPunten();
    Console.WriteLine("Punten Kamermuziek");
    int puntenKamermuziek = LeesPunten();
    Console.WriteLine("Punten Filosofie");
    int puntenFilosofie = LeesPunten();

    punten[leerling - 1, 0] = puntenSolfege;
    punten[leerling - 1, 1] = puntenKamermuziek;
    punten[leerling - 1, 2] = puntenFilosofie;
}
ToonPrestatiesPerLeerling(punten);


void ToonPrestatiesPerLeerling(int[,] punten)
{
    for (int leerling = 0; leerling < aantalLeerlingen; leerling++)
    {
        double totaalScore = 0;
        double laagsteBehaald = punten[leerling, 0];
        double hoogsteBehaald = punten[leerling, 0];

        for (int vak = 0; vak < 3; vak++)
        {
            totaalScore += punten[leerling, vak];

            if (laagsteBehaald < punten[leerling, vak])
            {
                laagsteBehaald = punten[leerling, vak];
            }
            else if (hoogsteBehaald > punten[leerling, vak])
            {
                hoogsteBehaald = punten[leerling, vak];
            }
        }
        double gemiddelde = totaalScore / 3;
        Console.WriteLine($"Leerling nummer {leerling + 1}: Hoogste behald {hoogsteBehaald}. Laagste behaald: {laagsteBehaald}. Gemiddelde: {gemiddelde:0.00}");

    }
}

int LeesPunten()
{
    Console.WriteLine("Geef punten tussen 0 en 20");
    while (true)
    {

        if (int.TryParse(Console.ReadLine(), out int punten) && punten >= 0 && punten <= 20)
        {
            return punten;
        }
        else
        {
            Console.WriteLine("Onmogelijk. Geef punten tussen 0 en 20");
        }
    }
}
