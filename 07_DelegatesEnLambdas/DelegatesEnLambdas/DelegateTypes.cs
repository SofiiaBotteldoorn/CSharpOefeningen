namespace DelegatesEnLambdas
{
    public delegate void Begroeting();
    public delegate bool GetalFilter(int getal);
    public delegate double Bewerking(double getal);
    public delegate string TransformeerTekst(string tekst);
    
    public class DelegateTypes
    {
        //Overload methods
        //Absoluut getal tonen
        public static void ToonGetallen(Action<int> absoluut, int[] getallen)
        {
            foreach (var getal in getallen)
            {
                absoluut(getal);
            }
        }
        //Voor Positieve/Even/Oneven getallen
        public static void ToonGetallen(GetalFilter filter, int[] getallen)
        {
            foreach (var getal in getallen)
            {
                if (filter(getal))
                {
                    Console.WriteLine(getal);
                }
            }
        }
        //Halveren/kwadraat tonen
        public static void ToonGetallen(Bewerking bewerking, int[] getallen)
        {
            foreach (var getal in getallen)
            {
                Console.WriteLine(bewerking(getal));
            }
        }

        public static void ToonSom(Func<int, int, int> totaal, int[] getallen)
        {
            int som = 0;
            foreach (var getal in getallen)
            {
                som = totaal(som, getal);
            }
            Console.WriteLine(som);
        }

        //Usernaam voor begroeting
        public static Dictionary<char, char> Letters = new Dictionary<char, char>
        {
            ['A'] = '4',
            ['B'] = '8',
            ['E'] = '3',
            ['G'] = '6',
            ['I'] = '1',
            ['L'] = '|',
            ['O'] = '0',
            ['S'] = '5',
            ['T'] = '7',
            ['Z'] = '2'
        };

        public static TransformeerTekst NaarUserNaam = (tekst) =>
        {
            string resultaat = "";

            for (int i = 0; i < tekst.Length; i++)
            {
                char letter = char.ToUpper(tekst[i]);
                if (Letters.ContainsKey(letter))
                {
                    resultaat += Letters[letter];
                }
                else
                {
                    resultaat += tekst[i];
                }
            }
            return (resultaat);
        };

        // Begroeting via multicast delegate (ToonWelkom, ToonDatum, ToonTijd)
        public static void ToonWelkom() => Console.WriteLine($"Welkom {NaarUserNaam(Console.ReadLine())}{new Random().Next(1, 100)}!");
        public static void ToonDatum() => Console.WriteLine($"Datum: {DateTime.Now.ToLongDateString()}");
        public static void ToonTijd() => Console.WriteLine($"Tijd: {DateTime.Now.ToShortTimeString()}\n");
    }
}
