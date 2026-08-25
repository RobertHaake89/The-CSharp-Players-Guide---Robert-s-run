using System;
using System.Data;

namespace NavigatingOperandCity;

class Coord
{
    public enum Direction
    { 
        South = 2,
        West = 4,
        East = 6,
        North = 8
    }

    public Direction DirectionRow {get; set;}
    public Direction DirectionColumn {get; set;}
    public Direction ChosenDirection {get; set;}

    public record BlockCoordinate(float row, float column)
    {
        public float Row {get; set;} = row;
        public float Column {get; set;} =  column;

        public BlockCoordinate?[] Coordinate = new BlockCoordinate?[9];
        public BlockCoordinate? this[int index]
        {
            get {return Coordinate[index];}
            set {Coordinate[index] = value;}
        }

        
        public static BlockCoordinate operator +(BlockCoordinate coord, BlockOffset offCoord)
        => new BlockCoordinate(coord.Row + offCoord.RowOff,coord.Column - offCoord.ColumnOffset);

        public static BlockCoordinate operator +(BlockCoordinate coord, Direction direction)
        {
            return direction switch
            {
                Direction.South => new BlockCoordinate(coord.Row, coord.Column + 1),
                Direction.West => new BlockCoordinate(coord.Row - 1, coord.Column),
                Direction.East => new BlockCoordinate(coord.Row + 1, coord.Column),
                Direction.North => new BlockCoordinate(coord.Row, coord.Column - 1),
                _ => throw new Exception("not valid")
            };
        }
    }

    public record BlockOffset(float RowOffset, float ColumnOffset)
    {
        public float RowOff {get; set;} = RowOffset;
        public float ColumnOff {get; set;} = ColumnOffset;
    }
}