using System;

namespace NavigatingOperandCity;

class Corrds
{
    public record BlockCoordinate();

    public record BlockOffset(int RowOffset, int ColumnOffset);
    public enum Direction { North, East, South, West}
}