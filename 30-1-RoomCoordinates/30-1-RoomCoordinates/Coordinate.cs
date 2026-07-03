using System;

namespace RoomCoordinates;

struct Coordinate
{
    private string _name {get; init;}
    private int _row {get; init;} = Random.Shared.Next(0,4);
    private int _column {get; init;} = Random.Shared.Next(0,4);


    public Coordinate(string name)
    {
        _name = name;
    }

    public static void GetCoordinate(Coordinate one, Coordinate two)
    {
        Console.WriteLine("\tX Y");
        Console.WriteLine($"{one._name}: {one._row} {one._column}");
        Console.WriteLine($"{two._name}: {two._row} {two._column}\n");
    }

    public static void MatchCoords(Coordinate one, Coordinate two)
    {
        bool isEqual = 
        one._row == two._row ||
        one._column == two._column ?
        true : false;

        string answer =
        isEqual ?
        $"{one._name} and {two._name} are adjacent!\n\n" :
        $"{one._name} and {two._name} aren't adjacent!\n\n";

        Console.WriteLine(answer);
    }
}