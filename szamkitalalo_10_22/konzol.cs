static class Konzol
{
    public static void Cim(string szoveg)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"═══ {szoveg} ═══");
        Console.ResetColor();
    }

    public static void menupont(string szoveg)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{szoveg}");
        Console.ResetColor();
    }

    public static void Siker(string szoveg)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{szoveg}");
        Console.ResetColor();
    }
}
