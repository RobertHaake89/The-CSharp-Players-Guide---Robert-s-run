using System;
using System.Data;
using System.Threading;

namespace TheOldRobot;

class Program
{
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n\t\tTHE OLD ROBOT\n\n");
        Thread.Sleep(2000);
        Console.Clear();

        Console.WriteLine("""
                    8-NORTH
            4-WEST            6-EAST
            1-ON    2-SOUTH   3-OFF


        """);

        Robot paul = new Robot();
        
        Console.Write("What's your first Command? ");
        int inputA = Convert.ToInt32(Console.ReadLine());
        paul.Commands[0] = Methods.GetCommand(inputA);

        Console.Write("And the second? ");
        int inputB = Convert.ToInt32(Console.ReadLine());
        paul.Commands[1] = Methods.GetCommand(inputB);

        Console.Write("Last but not least, the third One! ");
        int inputC = Convert.ToInt32(Console.ReadLine());
        paul.Commands[2] = Methods.GetCommand(inputC);

        paul.Run();
    }
}
