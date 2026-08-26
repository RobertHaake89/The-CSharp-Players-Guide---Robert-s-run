using System;
using System.Threading;

namespace TheRepeatingStream;

class Program
{
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;

        while (true)
        {
            //RecentNumbers.AddToMemory(Methods.GenerateRandomNumbers());

            

            Thread thread1 = new Thread(() =>
            {
                int number = Methods.GenerateRandomNumbers();

                RecentNumbers.AddToMemory(number);
                RecentNumbers.SetCounter();
                Console.Write($"{RecentNumbers.GetCounter()} ");

                //Console.Write($"Thread1 : {RecentNumbers.GetMemory()}");
            });

            Thread thread2 = new Thread(() =>
            {
                int number = Methods.GenerateRandomNumbers();

                RecentNumbers.AddToMemory(number);
                RecentNumbers.SetCounter();
                Console.Write($"{RecentNumbers.GetCounter()} ");

                //Console.WriteLine($"\tThread2 : {RecentNumbers.GetMemory()}");
            });
            
            

            thread1.Start();
            thread2.Start();

            //Console.Write($"{RecentNumbers.GetMemory()}, ");

            thread1.Join();
            thread2.Join();

            //Console.Write($"{RecentNumbers.GetCounter()} ");

            if (RecentNumbers.GetCounter() >= 100) break;
        }
    }
}