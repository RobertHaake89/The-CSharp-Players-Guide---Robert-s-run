using System;
using System.Dynamic;

namespace TheRobotFactory;

class Production
{
    public static void Process(Garage garage)
    {
        int incrementID = garage.Collection.Count;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("\tPRODUCTION PROCESS\n\n");

            dynamic robot = new ExpandoObject();

            robot.ID = incrementID++;
            robot.Name = "";
            robot.Width = 0f;
            robot.Heigth = 0f;
            robot.Color = "";

            robot.ID++;

            Console.WriteLine($"You are producing robot #{robot.ID}");

            Console.Write($"\nDo you want to add a custom name to robot #{robot.ID} (y/n)? ");
            string inputChoiceName = Console.ReadLine()!.ToLower();
            if (inputChoiceName == "y")
            {
                Console.Write("Name: ");
                robot.Name = Console.ReadLine()!;
            }
            else robot.Name = "";
            
            Console.Write($"\nDo you want to give robot {robot.Name} a custom Width and Heigth (y/n)? ");
            string inputChoiceSize = Console.ReadLine()!.ToLower();
            if (inputChoiceSize == "y")
            {
                Console.Write("Width in cm: ");
                robot.Width = Console.ReadLine();
                Console.Write("Heigth in cm: ");
                robot.Heigth = Console.ReadLine();
            }
            else
            {
                robot.Width = 0;
                robot.Heigth = 0;
            }

            Console.Write($"\nDo you want to add a custom color to robot {robot.Name} (y/n)? ");
            string inputChoiceColor = Console.ReadLine()!.ToLower();
            if (inputChoiceColor == "y")
            {
                Console.Write("Color: ");
                robot.Color = Console.ReadLine()!;
            }
            else robot.Color = "";

            Console.Clear();

            Console.WriteLine($"\nID: {robot.ID}");
            Console.WriteLine($"Name: {robot.Name}");
            Console.WriteLine($"Heigth: {(robot.Heigth is not 0 ? $"{robot.Heigth} cm" : "")}");
            Console.WriteLine($"Width: {(robot.Width is not 0 ? $"{robot.Width} cm" : "")}");
            Console.WriteLine($"Color: {robot.Color}");

            garage.Collection!.Add(robot.ID, robot);

            Console.Write("\nDo you want to create another robot (y/n)? ");
            string inputChoiceContinue = Console.ReadLine()!.ToLower();
            if (inputChoiceContinue == "y") continue;
            else break;
        }
    }
}