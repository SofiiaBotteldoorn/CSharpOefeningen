namespace DelegatesEnLambdas.Services
{
    public static class InvoerService
    {
        public static int VraagGetallen()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Hoeveel getallen?");
                if (int.TryParse(Console.ReadLine(), out int aantalGetallen) && aantalGetallen > 0)
                {
                    return aantalGetallen;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Onmogelijk. Probeer opnieuw");
                }
            }
        }

        public static int[] ArrayGetallenInvullen(int aantalGetallen)
        {
            int[] getallen = new int[aantalGetallen];
            for (int i = 0; i < getallen.Length; i++)
            {
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Geef getal: ");
                    if (int.TryParse(Console.ReadLine(), out int waarde))
                    {
                        getallen[i] = waarde;
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("U typt geen getal. Probeer opnieuw");
                    }
                }
            }
            return getallen;
        }
    }
}
