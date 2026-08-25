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

            var coord1 = new Coord.BlockCoordinate(resultCoord.Row, resultCoord.Column);
            var coord2 = new Coord.BlockCoordinate(resultDirection.Row, resultDirection.Column);
            
            blockCoord.Coordinate[0] = coord1;
            blockCoord.Coordinate[1] = coord2;

            Console.WriteLine($"\nNew Coord is ({blockCoord[0]?.Row}, {blockCoord[0]?.Column})");
            Console.WriteLine($"New Enum-Directed Coord is ({blockCoord[1]?.Row}, {blockCoord[1]?.Column})");

            Console.ReadKey();
        }
    }
}