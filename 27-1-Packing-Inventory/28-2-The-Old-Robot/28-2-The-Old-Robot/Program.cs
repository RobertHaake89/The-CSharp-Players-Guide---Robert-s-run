using System;
using System.Data;

namespace TheOldRobot;

class Program
{
    public static void Main()
    {
        Console.WriteLine("\t\tTHE OLD ROBOT\n\n");

        Robot paul = new Robot();

        paul.Commands[0] = new OnCommand();
        paul.Commands[1] = new OffCommand();
        paul.Commands[2] = new EastCommand();

       
        

        

        // 1 - ON       3 - OFF

        // 8 - NORTH    6 - EAST
        // 2 - SOUTH    4 - WEST

        paul.Run();
    }
}
