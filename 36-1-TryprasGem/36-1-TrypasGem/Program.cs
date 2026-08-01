using System;
using System.IO.Pipelines;

namespace TrypasGem;

class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("\n\tTRYPAS GEM\n\n");

            Console.Write("\nPlease enter your Input: ");
            string? inputString = Console.ReadLine();

            Console.WriteLine("""

            What do you want to check it for?
            1 - int
            2 - double
            3 - bool

            """);

            int inputCheck = Convert.ToInt32(Console.ReadLine());

            switch (inputCheck)
            {
                case 1:
                    Method.CheckInt(inputString!);
                    break;
                case 2:
                    Method.CheckDouble(inputString!);
                    break;
                case 3:
                    Method.CheckBool(inputString!);
                    break;
                default:
                    Console.WriteLine("Bad Input");
                    break;
            }
        }
    }
}