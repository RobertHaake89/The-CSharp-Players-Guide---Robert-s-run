using System;
using System.Collections.Generic;
using Coloreditems;

namespace ColoredItems;

class Program
{
    public static void Main()
    {
        Console.WriteLine("\n\t\tCOLORED ITEMS\n\n");

        ColoredItem<Sword> blueSword =
            new ColoredItem<Sword>(new Sword(), ConsoleColor.Blue);
        ColoredItem<Bow> redBow =
            new ColoredItem<Bow>(new Bow(), ConsoleColor.Red);
        ColoredItem<Axe> greenAxe =
            new ColoredItem<Axe>(new Axe(), ConsoleColor.Green);

        blueSword.Display();
        redBow.Display();
        greenAxe.Display();
    }   
}