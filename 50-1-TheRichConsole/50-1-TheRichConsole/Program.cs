using System;
using CSharpPlayersGuide.RichConsole;

namespace TheRichConsole;

class Program
{
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;

        for (int i = 100; i >= 0; i--)
        {
            if (i > 75) RichConsole.WriteLine($"{i}%", Colors.Green, null);
            else if (i > 50) RichConsole.WriteLine($"{i}%", Colors.Yellow, null);
            else if (i > 25) RichConsole.WriteLine($"{i}%", Colors.Orange, null);
            else RichConsole.WriteLine($"{i}%", Colors.Red, null);
        }
    }
}