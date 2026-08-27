using System;
using System.Threading;
using System.Linq;

namespace TheRepeatingStream;

public class Methods
{
    public static int GenerateRandomNumbers()
    {
        //int i = 0;
        int randomNumber;

        while (true)
        {
            randomNumber = Random.Shared.Next(1,10);
            Thread.Sleep(10);
            return randomNumber;
        }
    }

    public static void ThreadingProcess(int memory, ref List<int> evenNumList, ref List<int> oddNumList)
    {
        int number = GenerateRandomNumbers();

                RecentNumbers.AddToMemory(number);
                RecentNumbers.SetCounter();
                Console.Write($"{RecentNumbers.GetCounter()} ");

                if (memory % 2 == 0)
                {
                    evenNumList.Add(memory);
                }
                else if (memory % 2 != 0)
                {
                    oddNumList.Add(memory);
                }
                else throw new Exception("Error");
    }

    public static void ConcurrencyCheck(in List<int> evenNumList, in List<int> oddNumList)
    {
        if (RecentNumbers.GetCounter() == RecentNumbers.maxLoops)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine($"\n\nEven Numbers: {evenNumList.Count}");
            Console.WriteLine($"Odd Numbers: {oddNumList.Count}");

            int numberDiviating = Math.Abs(evenNumList.Count - oddNumList.Count);

            string resultMessage
                = evenNumList.Count == oddNumList.Count
                    ? "No Concurrency Errors Detected!"
                    : $"{numberDiviating} Concurrency Errors Detected!";

            Console.WriteLine($"\n{resultMessage}\n");

            Console.ResetColor();
        }
    }
}