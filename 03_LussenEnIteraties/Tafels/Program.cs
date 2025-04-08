//------------------------
// Getal vragen + for-lus
//------------------------

int getal;
do
{
    Console.WriteLine("Geef positieve getal voor tafel:");
    getal = int.Parse(Console.ReadLine());
}
while (getal <= 0);

for (int teller = 1; teller <= 10; teller++)
{
    Console.WriteLine($"{getal} X {teller} = {getal * teller}");
}
