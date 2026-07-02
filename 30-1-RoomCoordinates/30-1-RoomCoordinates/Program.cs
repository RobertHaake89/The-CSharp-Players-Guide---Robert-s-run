using System;
using System.Drawing;

namespace RoomCoordinates;

class Program
{
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n\n\t\tROOM COORDINATES\n\n");

        Coordinate point1 = new Coordinate("Point1", 2, 4);
        Coordinate point2 = new Coordinate("Point1", 3, 4);

        point1.GetCoordinate();

        //Console.WriteLine($"{point1._row} {point2._column}");
    }
}