using System;

namespace CeruleanForge;

// Represents the current state of a material. This is a wrapper around a 2D grid
// of colors with some utility methods to make that easier to do.
public class Material
{
    // The underlying color data of the material.
    private Color?[,] _data;

    // The size (assumed to be equal in rows and columns) of the material.
    public int Size { get; }

    // Creates a new material of a given size.
    public Material(int size)
    {
        Size = size;
        _data = new Color?[size, size];
    }

    // Resets the material to all null color values (without resizing it).
    public void Reset()
    {
        _data = new Color?[Size, Size];
    }

    // Returns the color at the current location.
    // For convenience, if you ask for something "off the grid", this will return
    // null instead of crashing.
    public Color? GetData(int row, int column)
    {
        if (row < 0) return null;
        if (column < 0) return null;
        if (row >= _data.GetLength(0)) return null;
        if (column >= _data.GetLength(1)) return null;
        return _data[row, column];
    }

    // Updates the material at the given location to the given color.
    public void SetData(int row, int column, Color? value)
    {
        _data[row, column] = value;
    }
}
