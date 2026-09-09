using System;
using System.Data;

namespace CeruleanForge;

// Represents the current state of a material. This is a wrapper around a 2D grid
// of colors with some utility methods to make that easier to do.
public class Material
{
    // The underlying color data of the material.
    private Color?[,] _data;
    public Color? this[int row, int column/* , Color? color */]
    {
        get  
        {
            if (row < 0) return null;
            if (column < 0) return null;
            if (row >= _data.GetLength(0)) return null;
            if (column >= _data.GetLength(1)) return null;

            return _data[row, column];
        }
        set
        {
                
            _data[row, column] = value;
            DataChanged?.Invoke(new Position(row, column));
        }
            
    }

    // The size (assumed to be equal in rows and columns) of the material.
    public int Size { get; }

    // Creates a new material of a given size.
    public Material(int size)
    {
        Size = size;
        
        _data = new Color?[size, size];
    }

    public event Action<Position>? DataChanged;

    // Resets the material to all null color values (without resizing it).
    public void Reset()
    {
        _data = new Color?[Size, Size];
    }
}
