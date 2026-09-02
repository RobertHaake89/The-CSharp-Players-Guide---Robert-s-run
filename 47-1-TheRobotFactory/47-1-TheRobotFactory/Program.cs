using System;
using System.Dynamic;
using Microsoft.VisualBasic;

namespace TheRobotFactory;

class Program
{
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;

        var garage = new Garage();
        

        Production.Process(garage);

        Console.Clear();
        Console.WriteLine("These are all robots you've created:\n");

        foreach (var property in garage.Collection)
        {
            dynamic robot = property.Value;

            Console.WriteLine($"{robot.ID}: {robot.Name}"); 
        }
        
    }
}
