using System;

namespace CeruleanForge;


// Represents a position within a material, with a row and column.
public record Position(int Row, int Column)
{
    // Wraps the given location to a particular size.
    // If, for example, the size is 20, and the position is at (22, 24),
    // this will be wrapped so that the returned position is (2, 4).
    public static Position Wrap(Position position, int size)
    {
        // RUBBLE: WRAPPED UP
        return new Position((position.Row - size) /*% size*/, (position.Column - size) /*% size*/);
    }
}