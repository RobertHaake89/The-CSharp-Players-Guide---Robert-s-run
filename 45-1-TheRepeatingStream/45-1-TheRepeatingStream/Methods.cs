using System;
using System.Threading;
using System.Linq;

namespace TheRepeatingStream;

public class Methods
{
    public static void Initilisation()
    {
        Console.WriteLine("\tTHE REPEATING STREAM - Concurrency Test\n\n");

        Console.WriteLine($"A loop with 2 synced Threads will count to {RecentNumbers.MaxLoops}.");
        Console.WriteLine("The Lock has already been added in Numbers.cs.");
        Console.WriteLine("You can disassemble the Lock to see the difference.");

        Console.WriteLine("\nEpilepsy Warning: Rapidly changing text.");

        Console.WriteLine("\n\nPress any Button to start!");

        Console.ReadKey();

        Console.Clear();
        Console.Write("\nInitializing");

        int counter = 1;

        for (int i = 1; i <= 3; i++)
        {
            Console.Write($"\n{counter++} ");

            for (int j = 1; j <= 3; j++)
            {
                Console.Write(" .");
                Thread.Sleep(600);
            }
        }

        Console.WriteLine("\nSTART");
        Thread.Sleep(1000);
    }

    public static int GenerateRandomNumber()
    {
        int randomNumber;

        randomNumber = Random.Shared.Next(1,11);
        return randomNumber;
    }

    public static void ConcurrencyCheck(in List<int> evenNumList, in List<int> oddNumList)
    {
        if (RecentNumbers.GetCounter() >= RecentNumbers.MaxLoops)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine($"\n\nEven Numbers: {evenNumList.Count}");
            Console.WriteLine($"Odd Numbers: {oddNumList.Count}");

            int numberDiviating = Math.Abs(evenNumList.Count - oddNumList.Count);

            string resultMessage
                = evenNumList.Count + oddNumList.Count == RecentNumbers.GetCounter()
                    ? "No Concurrency Errors Detected!"
                    : $"{numberDiviating} Concurrency Errors Detected!";

            Console.WriteLine($"\n{resultMessage}\n");

            Console.ResetColor();
        }
    }
}