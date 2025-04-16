//-------------------------------------------------
// Gebaseerd op naam, familienaam, gsm en postcode
// StringBuilder, substrings, validaties
//-------------------------------------------------
using System.Text;

StringBuilder wifiWachtwoord = new StringBuilder();

Console.WriteLine("Uw naam:");
string naam = Console.ReadLine();
if (string.IsNullOrWhiteSpace(naam) || naam.Length < 2)
    naam = "Onbekend";

Console.WriteLine("Uw familienaam:");
string familienaam = Console.ReadLine();
if (string.IsNullOrWhiteSpace(familienaam) || familienaam.Length < 2)
    familienaam = "Anoniem";

Console.WriteLine("Uw gsm:");
string gsmNummer = Console.ReadLine();
if (string.IsNullOrWhiteSpace(gsmNummer) || gsmNummer.Length < 3)
    gsmNummer = "0111111111";

Console.WriteLine("Uw postcode:");
string postcode = Console.ReadLine();
if (string.IsNullOrWhiteSpace(postcode) || postcode.Length < 4)
    postcode = "9999";

// 1ste 2 letters van naam
wifiWachtwoord.Append(naam.Substring(0, 2).ToUpper());

// Laatste 2 letters van familienaam
wifiWachtwoord.Append(familienaam.Substring(familienaam.Length - 2).ToLower());

// Eerste 3 cijfers van gsm zonder nullen
string gsmClean = gsmNummer.Replace("0", "");
wifiWachtwoord.Append(gsmClean.Length >= 3 ? gsmClean.Substring(0, 3) : gsmClean.PadRight(3, '_'));

// Laatste 2 cijfers van postcode
wifiWachtwoord.Append(postcode.Substring(postcode.Length - 2));
//Voeg $ op positie 4
wifiWachtwoord.Insert(4, "$");

Console.WriteLine($"Uw wifiwachtwoord is {wifiWachtwoord}");