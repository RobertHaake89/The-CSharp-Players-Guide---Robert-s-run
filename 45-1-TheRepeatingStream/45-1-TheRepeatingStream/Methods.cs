using System;
using System.Threading;
using System.Linq;

namespace TheRepeatingStream;

public class Methods
{
    public static int GenerateRandomNumbers()
    {
        int randomNumber;

        while (true)
        {
            randomNumber = Random.Shared.Next(1,11);
            return randomNumber;
        }
    }

    public static void ConcurrencyCheck(in List<int> evenNumList, in List<int> oddNumList)
    {
        if (RecentNumbers.GetCounter() >= RecentNumbers.maxLoops)
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