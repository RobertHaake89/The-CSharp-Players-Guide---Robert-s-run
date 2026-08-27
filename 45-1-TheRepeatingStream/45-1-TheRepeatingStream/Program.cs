using System;
using System.Threading;
using static TheRepeatingStream.RecentNumbers;
using static TheRepeatingStream.Methods;


namespace TheRepeatingStream;

class Program
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine(" ");

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Thread thread1 = new Thread(ThreadingProcess);
            Thread thread2 = new Thread(ThreadingProcess);
            
            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            ConcurrencyCheck(GetEvenNumber(), GetOddNumber());
            if (GetCounter() >= maxLoops) break;
        }
    }
}