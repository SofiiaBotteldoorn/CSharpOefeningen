using StadPostcode;

string inputStad = LeesStad();
while (inputStad != "stop")
{
    ToonPostcode(inputStad);
    inputStad = LeesStad();
}

string LeesStad()
{
    while (true)
    {
        Console.WriteLine($"Stad (stop om te stoppen): ");
        string? inputStad = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(inputStad) || inputStad.Any(char.IsDigit))
        {
            Console.WriteLine("Onmogelijk. Stad naam mag niet leegzijn en mag geen cijfers bevatten");
            Console.WriteLine();
        }
        else
        {
            return inputStad;
        }
    }
}
void ToonPostcode(string inputStad)
{
    try
    {
        PostcodesInfo info = new PostcodesInfo();
        Console.WriteLine($"De postcode van {inputStad} is {info.Postcode(inputStad)}");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    Console.WriteLine();
}