using System;
using System.Reflection;
using System.Linq;

namespace TheThreeLenses;

class Program
{
    public static void main()
    {
        var collectionPrimal = new int[] {1,9,2,8,3,7,4,6,5};

        LINQ_Methods.SetArray(collectionPrimal, out IEnumerable<int> evenPrimal);

    }
}