using System;
using System.Collections.Generic;

namespace PackingInventory;

class Program
{
    public static void Main()
    {
        Console.WriteLine("\t\tPacking Inventory\n\n");

        Console.ForegroundColor = ConsoleColor.Green;

        Pack pack = new Pack(10,10,10); // count, weight, volume

        PackingProcess.GeneralLoop(pack);

    }
}