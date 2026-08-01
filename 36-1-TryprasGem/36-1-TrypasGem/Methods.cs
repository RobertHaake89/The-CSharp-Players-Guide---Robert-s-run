using System;

namespace TrypasGem;

class Method
{
    public static void CheckInt(string input)
    {
        bool successful = false;

        while (!successful)
        {
            if (int.TryParse(input, out int result))
            {
                successful = true;
            }

            Console.WriteLine($"\nSuccess? {successful} Value={result}");

            Console.Write("\nPress any Button to continue ");
            Console.ReadKey();
        }
    }

    public static void CheckDouble(string input)
    {
        bool successful = false;

        while (!successful)
        {
            if (double.TryParse(input, out double result))
            {
                successful = true;
            }

            Console.WriteLine($"\nSuccess? {successful} Value={result}");

            Console.Write("\nPress any Button to continue ");
            Console.ReadKey();
        }
    }

    public static void CheckBool(string input)
    {
        bool successful = false;

        while (!successful)
        {
            if (bool.TryParse(input, out bool result))
            {
                successful = true;
            }

            Console.WriteLine($"\nSuccess? {successful} Value={result}");

            Console.Write("\nPress any Button to continue ");
            Console.ReadKey();
        }
    }
}