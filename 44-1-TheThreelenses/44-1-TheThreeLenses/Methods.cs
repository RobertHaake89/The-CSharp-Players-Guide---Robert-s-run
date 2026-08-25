using System;
using System.Linq;

namespace TheThreeLenses;

class LINQ_Methods
{
    public static void SetArray(int[] primalArray, IEnumerable<int> evenPrimal)
    {
        int[] tempColection = new int[10];
        int i = 0;

        foreach (int number in primalArray)
        {
            if (number % 2 == 0)
            {
                tempColection[i] = number;
                i++;
            }
            
        }

        evenPrimal = tempColection;
        
        
        
        
        
       


        
    }
}