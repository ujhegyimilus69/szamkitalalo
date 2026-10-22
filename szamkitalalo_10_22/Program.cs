using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

const int Szelesseg = 35;

Console.ForegroundColor = ConsoleColor.Cyan;

Konzol.Cim("Számkítaláló");

Konzol.menupont($" [1] Játék");

Konzol.menupont($" [2] Kilépés");
Console.WriteLine("Hanyadik menüpont?");
int menupont = Convert.ToInt32(Console.ReadLine());

int szam = Random.Shared.Next(1, 101);
int kulonbseg = 100 - szam;
int talalat = 0;


do 
{
    
    switch (menupont)
    {
        case 1:
            Console.WriteLine("Tippelj a számra: ");
            int tipp = Convert.ToInt32(Console.ReadLine());
            if (tipp == szam)
            {
                Konzol.Siker("gratu");
                   talalat = 1;
                break;
            }
            else if (kulonbseg <= 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nagyon közel van!");
                Console.ResetColor();
                break;
            }
            else if (6 <= kulonbseg && kulonbseg <= 20)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Közelebb vagy!");
                Console.ResetColor();
                break;
            }
            else if (20 <= kulonbseg)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Messze vagy!");
                Console.ResetColor();
                break;
            }
            break;

        case 2:
            Console.WriteLine("Kilépés...");
            break;



    }
} while (talalat != 1);
