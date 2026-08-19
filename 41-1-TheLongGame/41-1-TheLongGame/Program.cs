global using System;
global using System.IO;
global using System.Linq;

namespace TheLongGame;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("\n\t\tTHE LONG GAME\n\n");

        Console.WriteLine("What's your name?");
        string? name = Console.ReadLine();

        Methods.CheckScore(name!, out int score);
        
        while (true)
        {
            Console.Clear();
            
            Console.WriteLine($"Name: {name}\tScore: {score}");
            
            if (Console.ReadKey().Key == ConsoleKey.Enter ) break;

            score++;
        }
        
        Methods.AddToFile(name!, score);
    }
}