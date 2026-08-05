using System;
using System.ComponentModel.DataAnnotations;

namespace BetterRandom;

class Program
{
    public static void Main()
    {
        Console.WriteLine("\n\tBETTER RANDOM\n\n");

        double targetDouble = 0;
        string? direction = null;
        bool coin = true;

        Console.WriteLine(targetDouble.RandomDouble().TrimDouble());
        Console.WriteLine(direction!.RandomDirection().ToTitleCase());
        Console.WriteLine(coin.TossCoin().ToTitleCase());
    }
}