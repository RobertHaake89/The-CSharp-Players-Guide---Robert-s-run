using System;
using System.Threading;
using static TheRepeatingStream.RecentNumbers;
using static TheRepeatingStream.Methods;


namespace TheRepeatingStream;

class Program
{
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Clear();

        Initilisation();

        while (true)
        {
            Thread thread1 = new Thread(ThreadingProcess);
            Thread thread2 = new Thread(ThreadingProcess);
            
            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            ConcurrencyCheck(GetEvenNumber(), GetOddNumber());
            if (GetCounter() >= MaxLoops) break;
        }
    }
}