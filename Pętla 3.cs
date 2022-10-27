int liczba = 0;
bool sukces;


do
{
    Console.Write("Podaj całkowitą liczbę dodatnią: ");
    sukces = int.TryParse(Console.ReadLine(), out liczba);
}
while ((!sukces) || (liczba < 0));

for (int linia = 1; linia <= liczba; linia++)
{
    for (int i = 1; i <= liczba; i++)
    {
        Console.Write("X");
    }
    Console.Write("\n");
}
Console.ReadKey();
