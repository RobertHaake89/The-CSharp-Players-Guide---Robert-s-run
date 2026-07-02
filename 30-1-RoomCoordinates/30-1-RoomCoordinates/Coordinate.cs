using System;

namespace RoomCoordinates;

struct Coordinate
{
    private string _name {get; init;}
    private int _row {get; init;}
    private int _column {get; init;}

    public Coordinate(string name, int row, int column)
    {
        _name = name;
        _row = row;
        _column = column;
    }

    public void GetCoordinate()
    {
        Console.WriteLine($"{_row} {_column}");
    }
}