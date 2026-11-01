using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

bool kilep = false;

while (kilep != true)
{
    Console.ForegroundColor = ConsoleColor.Cyan;

    Konzol.Cim("Számkítaláló");
    Konzol.menupont($" [1] Játék");
    Konzol.menupont($" [2] Kilépés");
    Console.WriteLine("Hanyadik menüpont?");
    if (!int.TryParse(Console.ReadLine(), out int menupont))
    {
        Console.WriteLine("Számot írj be!");
        continue;
    }

    switch (menupont)
    {
        case 1:
            Jatek();
            break;

        case 2:
            Console.WriteLine("Kilépés...");
            kilep = true;
            break;

        default:
            Console.WriteLine("Nincs ilyen menüpont.");
            break;

    }
    }

    static void Jatek()
{
    int szam = Random.Shared.Next(1, 101);
    int probalkozas = 0;
    bool talalat = false;

    while (talalat != true)
    {
        Console.WriteLine("Tippelj a számra: ");

        if (!int.TryParse(Console.ReadLine(), out int tipp))
        {
            Console.WriteLine("Számot írj be!");
            continue;
        }

        probalkozas++;
        int kulonbseg = Math.Abs(szam - tipp);

        if (kulonbseg == 0)
        {
            Konzol.Siker($"Gratulálok! {probalkozas} tippből sikerült.");
            talalat = true;
        }
        else if (kulonbseg <= 5)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nagyon közel van!");
            Console.ResetColor();
        }
        else if (kulonbseg <= 20)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Közelebb vagy!");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Messze vagy!");
            Console.ResetColor();
        }
    }
}



