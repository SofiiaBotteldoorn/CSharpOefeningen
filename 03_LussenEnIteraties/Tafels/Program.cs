//------------------------
// Getal vragen + for-lus
//------------------------

int getal;
do
{
    Console.WriteLine("Geef positieve getal voor tafel:");
    if(int.TryParse(Console.ReadLine(), out getal) &&  getal > 0)
    {
        break;
    }
    else 
    {
       Console.WriteLine("Ongeldig invoer");
    }
}
while (getal <= 0);

for (int teller = 1; teller <= 10; teller++)
{
    Console.WriteLine($"{getal} X {teller} = {getal * teller}");
}
