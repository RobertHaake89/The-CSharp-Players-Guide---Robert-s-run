using System;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;

namespace TheThreeLenses;

class LINQ_Methods
{
    public static void GetPrimalArray(int[] inputArray)
    {
        int[] tempCollection = new int[10];
        int i = 0;

        foreach (int number in inputArray)
        {
            if (number % 2 == 0)
            {
                tempCollection[i] = number;
                i++;
            }
        }

        Array.Sort(tempCollection);
        IEnumerable<int> evenPrimal = tempCollection;
        
        foreach (int number in evenPrimal)
        {
            if (number != 0) Console.Write($"{number} ");
        }
    }

    public static void GetKeywordQuery(int[] inputArray)
    {
        IEnumerable<int> tempCollection =
        from n in inputArray
        where n % 2 == 0
        where n > 0
        orderby n
        select n;

        foreach (int number in tempCollection)
        {
            Console.Write($"{number} ");
        }
    }

    public static void GetMethodCallQuery(int[] inputArray)
    {
        IEnumerable<int> keywordQuery = inputArray
                                        .Where(n => n % 2 == 0)
                                        .Where(n => n > 0)
                                        .OrderBy(n => n);

        foreach (int number in keywordQuery)
        {
            Console.Write($"{number} ");
        }
    }
}