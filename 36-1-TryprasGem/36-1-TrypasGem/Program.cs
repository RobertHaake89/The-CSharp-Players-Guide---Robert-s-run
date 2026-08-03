using System;
using System.Globalization;

namespace TrypasGem;

class Program
{
    public static void Main()
    {
        CultureInfo.CurrentCulture = new CultureInfo("en-US"); // international "."-usage for double, not ","
        CultureInfo.CurrentUICulture = new CultureInfo("en-US");

        bool isRunning = true;

        while (isRunning)
        {
            Console.Clear();
            Console.WriteLine("\n\tTRYPAS GEM\n");

            Console.Write("\nPlease enter your Input: ");
            string? inputString = Console.ReadLine();

            Console.WriteLine("""

            What do you want to check it for?
            
            1 - int
            2 - double
            3 - bool

            9 - exit

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
                case 9:
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Bad Input");
                    break;
            }
        }
    }
}