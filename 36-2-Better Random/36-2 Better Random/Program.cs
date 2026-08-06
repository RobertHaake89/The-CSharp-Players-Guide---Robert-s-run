using System;
using System.ComponentModel.DataAnnotations;

namespace BetterRandom;

class Program
{
    public static void Main()
    {
        Console.WriteLine("\n\tBETTER RANDOM\n\n");

        int isRunning = 0;
        while (isRunning < 100)
        {
            double targetDouble = 0;
            string? direction = null;
            bool isHead = true;

            Console.Write($"{targetDouble.RandomDouble().TrimDouble()}\t");
            Console.Write($"{direction!.RandomDirection().ToTitleCase()}\t");
            Console.WriteLine($"{isHead.TossCoin().ToTitleCase()}");

            isRunning++;
        }
    }
}