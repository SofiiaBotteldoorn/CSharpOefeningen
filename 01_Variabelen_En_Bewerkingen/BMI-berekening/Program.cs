//--------------------------------------------------------
// BMI-berekening
// Gewicht, lengte, switch-statement voor interpretatie
//--------------------------------------------------------

Console.WriteLine("Uw gewicht (kg):");

if (float.TryParse(Console.ReadLine(), out float gewicht))
{
    Console.WriteLine("Uw lengte (bv.1,83):");
    if (float.TryParse(Console.ReadLine(), out float lengte))
    {
        float bmi = gewicht / (lengte * lengte);
        if (bmi >= 18.5 && bmi <= 24.9)
        {
            Console.WriteLine($"{bmi:0.00}. Uw BMI is gezond.");
        }
        else if (bmi < 18.5)
        {
            Console.WriteLine($"{bmi:0.00}. Uw BMI is te laag.");
        }
        else if (bmi > 24.9)
        {
            Console.WriteLine($"{bmi:0.00}. Uw BMI is te hoog.");
        }
    }
    else
    {
        Console.WriteLine("Verkeerde gegevens"); //als Parse mislukt
    }
}
else
{
    Console.WriteLine("Verkeerde gegevens"); //als Parse mislukt
}


        //Versie met switch:
/*
Console.WriteLine("Uw gewicht: (bv. 55,5)");
double gewicht = double.Parse(Console.ReadLine());
Console.WriteLine("Uw lengte: (bv. 1,65)");
double lengte = double.Parse(Console.ReadLine());
double bmi = gewicht / (lengte * lengte);
string bericht = bmi switch
{
    >= 18.5 and <= 24.9 => "Uw BMI is gezond.",
    < 18.5 => "Uw BMI is te laag.",
    > 24.9 => "Uw BMI is te hoog."
};
Console.WriteLine($"{bmi:0.00}. {bericht}");
*/
