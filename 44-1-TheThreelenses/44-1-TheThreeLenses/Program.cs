using System;
using System.Reflection;
using System.Linq;

namespace TheThreeLenses;

class Program
{
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;

        var collectionPrimal = new int[] {1,9,2,8,3,7,4,6,5};

        Console.Write("\nArray Numbers: ");
        foreach (int n in collectionPrimal)
        {
            Console.Write($"{n} ");
        }

        Console.Write("\n\nIf-Filtered Numbers:  ");
        LINQ_Methods.GetEvenNumbers(collectionPrimal);

        Console.Write("\nKeyword-Called Query: ");
        LINQ_Methods.GetKeywordQuery(collectionPrimal);

        Console.Write("\nMethod-Called Query:  ");
        LINQ_Methods.GetMethodCallQuery(collectionPrimal);

        Console.WriteLine("\n");
    }
}