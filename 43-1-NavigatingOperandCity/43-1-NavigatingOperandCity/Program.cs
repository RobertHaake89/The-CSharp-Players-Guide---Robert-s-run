using System;
using System.Data;

namespace NavigatingOperandCity;

class Program
{
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n\n\tNavigating Operand City\n\n");

        while (true)
        {
            Console.Clear();

            Console.Write("BlockCoord row: ");
            float inputCoordRow = Convert.ToInt64(Console.ReadLine());
            Console.Write("BlockCoord column: ");
            float inputCoordColumn = Convert.ToInt64(Console.ReadLine());

            Console.Write("\nBlockOffset row: ");
            float inputOffCordRow = Convert.ToInt64(Console.ReadLine());
            Console.Write("BlockOffset column: ");
            float inputOffCordColumn = Convert.ToInt64(Console.ReadLine());

            Console.Write("\nFor the second Coord add a cardinal direction (Keypad #): ");
            Coord.Direction inputDirection = (Coord.Direction)Convert.ToInt32(Console.ReadLine());


            Coord.BlockCoordinate blockCoord = new(inputCoordRow,inputCoordColumn);
            Coord.BlockOffset blockOffset = new(inputOffCordRow,inputOffCordColumn);

            Coord.BlockCoordinate resultCoord = blockCoord + blockOffset;
            Coord.BlockCoordinate resultDirection =  blockCoord + inputDirection;


            Console.WriteLine($"\nNew Coord is ({resultCoord.Row}, {resultCoord.Column})");
            Console.WriteLine($"New Enum-Directed Coord is ({resultDirection.Row}, {resultDirection.Column})");

            Console.ReadKey();
        }
    }
}