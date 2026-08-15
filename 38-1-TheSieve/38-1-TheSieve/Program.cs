using System;
using System.Collections;

namespace TheSieve;

class Program
{
    static void Main()
    {
        Console.WriteLine("\n\n\t\tTHE SIEVE");

        var sieve = new Sieve();

        Delegate.SieveDelegate even = Delegate.CheckEven;
        Delegate.SieveDelegate positive = Delegate.CheckPositive;
        Delegate.SieveDelegate multipleTen = Delegate.CheckMultipleTen;
        
        while (true)
        {
            Console.Clear();

            Console.Write("\nEnter Number for sieving: ");
            int chosenNum = int.Parse(Console.ReadLine());
            sieve.SetNumber(chosenNum);

            Console.WriteLine("\nWhat do you want to check?");
            Console.WriteLine("1 - even");
            Console.WriteLine("2 - positive");
            Console.WriteLine("3 - multiple of ten");

            int inputCheck = int.Parse(Console.ReadLine());

            Delegate.SieveDelegate chosenCheck = inputCheck switch
            {
                1 => even,
                2 => positive,
                3 => multipleTen,
                _ => throw new Exception("thats a bad choice")
            };

            sieve.SetCondition(chosenCheck);

            Console.WriteLine($"\n{sieve.GetNumber()} is {sieve.GetCondition()}");
            
            Console.ReadKey(true);
        }
    }
}