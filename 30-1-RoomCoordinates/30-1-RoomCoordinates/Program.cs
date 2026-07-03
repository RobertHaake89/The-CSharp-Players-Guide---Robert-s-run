using System;

namespace RoomCoordinates;

class Program
{
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n\n\t\tROOM COORDINATES\n\n");

        Coordinate point1 = new Coordinate("Point1");
        Coordinate point2 = new Coordinate("Point2");

        Coordinate.GetCoordinate(point1, point2);

        Coordinate.MatchCoords(point1, point2);
    }
}