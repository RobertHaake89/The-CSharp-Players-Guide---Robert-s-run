using System;

namespace ExceptisGame;

class Display
{
    public static void Header(NumberCollector numCollector)
    {
        Console.WriteLine("\n\tEXCEPTI'S GAME\n\n");

        NumberList(numCollector);
    }

    public static void NumberList(NumberCollector numCollector)
    {
        int i = 0;

        for (; i < numCollector.GetContent().GetLength(0); i++)
        {
            if (numCollector.GetContent()[i] == 0)
            {
                Console.Write(" ");
            }
            else Console.Write($"{numCollector.GetContent()[i]}  ");
        }
    }
}