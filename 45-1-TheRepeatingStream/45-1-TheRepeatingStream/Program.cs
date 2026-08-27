using System;
using System.Threading;
using static TheRepeatingStream.RecentNumbers;
using static TheRepeatingStream.Methods;


namespace TheRepeatingStream;

class Program
{
    public static void Main()
    {
        /*int[] evenNumber = new int[RecentNumbers.maxLoops];
        int[] oddNumber = new int[RecentNumbers.maxLoops];*/
        Console.WriteLine(" ");

        while (true)
        {
            //RecentNumbers.AddToMemory(Methods.GenerateRandomNumbers());
            Console.ForegroundColor = ConsoleColor.Green;
            

            Thread thread1 = new Thread(() =>
            {
                ThreadingProcess(GetMemory(), ref EvenNumber, ref OddNumber);
            });

            Thread thread2 = new Thread(() =>
            {
                ThreadingProcess(GetMemory(), ref EvenNumber, ref OddNumber);
            });
            
            

            thread1.Start();
            thread2.Start();

            //ConcurrencyCheck(GetMemory(),ref EvenNumber, ref OddNumber);
            //Console.Write($"{RecentNumbers.GetMemory()}, ");

            thread1.Join();
            thread2.Join();

            //Console.Write($"{RecentNumbers.GetCounter()} ");

            ConcurrencyCheck(in EvenNumber, in OddNumber);
            if (GetCounter() >= maxLoops) break;
        }
    }
}