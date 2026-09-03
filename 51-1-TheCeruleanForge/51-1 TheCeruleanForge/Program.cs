using System;

namespace Starter;


public class Program
{
    public static void Main()
    {
Material material = new Material(85);
Strand[] strands =
[
    new Strand(material, "*^*^*^*<<*<*<*<*vv*v*v*v*>>*>*>*>*>>>>>>>>>^^^^", Colors.White, new Position(1, 3), new Position(0, 0)),
    new Strand(material, "*^*^*^*^*^*^*^*<<^^", Colors.White, new Position(3, 5), new Position(0, 0)),
    new Strand(material, "*>*v*<*^>>>>>>>>>^^", Colors.White, new Position(0, 0), new Position(0, 0)),
    new Strand(material, "*>*>*>*>*>*>*>*^^>>", Colors.White, new Position(3, 7), new Position(0, 0)),
];

CeruleanForge forge = new (material, strands);
forge.Run();
    }
}

// Represents the entire forge, which uses a set of strands to weave a material.
public class CeruleanForge(Material material, Strand[] strands)
{
    // The material being woven.
    public Material Material { get; } = material;

    // The set of strands doing the weaving.
    public Strand[] Strands { get; } = strands;

    // Runs the strands to weave the material. This runs indefinitely.
    public void Run()
    {
        // Puts the console window into a good initial state.
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Clear();
        Console.CursorVisible = false;

        // Before we get started, make a renderer to show our progress.
        Renderer renderer = new Renderer(Material);
        while (true)
        {
            // Run one instruction for each strand.
            foreach (Strand strand in Strands)
                strand.RunNextInstruction();

            // Stop and wait briefly, to create an illusion that it takes a bit 
            // of time to weave materials. This is purely for storytelling 
            // purposes, and you can remove it at your discretion. (But note that
            // the initial flavor of rendering just takes some time and will 
            // still run a bit slow. That will be fixed in one of the                  
            // challenges.)
            Thread.Sleep(10);
            renderer.Render();
        }
    }
}


// Contains the logic for rendering a material’s current state during weaving.
public class Renderer
{
    private readonly Material _material;

    // We remember the previous size so we can detect a resize.
    private int _previousWidth = 0;
    private int _previousHeight = 0;

    public Renderer(Material material)
    {
        _material = material;
    }

    public void Render()
    {
        // If the window is resized, let's start fresh.
        if (WindowHasBeenResized())
            ResetEverything();

        // Goes through each row and column in the material (two rows at a time, 
        // since the console window draws two "pixels" per text character.
        // (These rows and columns are console rows and columns, not for the
        // material.)
        Console.Clear();
        for (int row = 0; row < _material.Size / 2; row++)
        {
            for (int column = 0; column < _material.Size; column++)
            {
                RenderConsoleLocation(row, column);
            }
            Console.WriteLine();
        }
    }

    // Renders the character at a given row and column, figuring out what the 
    // colors should be for the top (background) and bottom (foreground) halves.
    private void RenderConsoleLocation(int row, int column)
    {
        Color? topHalf = _material.GetData(row * 2, column);
        Color? bottomHalf = _material.GetData(row * 2 + 1, column);

        Console.Write($"{GetForeground(bottomHalf)}{GetBackground(topHalf)}▄");
    }

    private string GetForeground(Color? color)
    {
        color ??= Colors.Black;
        return $"\e[48;2;{color.R};{color.G};{color.B}m"; // ANSI command codes.
    }

    private string GetBackground(Color? color)
    {
        color ??= Colors.Black;
        return $"\e[38;2;{color.R};{color.G};{color.B}m"; // ANSI command codes.
    }

    private void ResetEverything()
    {
        _previousWidth = Console.BufferWidth;
        _previousHeight = Console.BufferHeight;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.Clear();
        _material.Reset();
    }

    private bool WindowHasBeenResized()
    {
        if (_previousWidth != Console.BufferWidth) return true;
        if (_previousHeight != Console.BufferHeight) return true;
        return false;
    }
}


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


// Represents a strand, moving around in the material.
public class Strand
{
    public int NextInstruction { get; private set; }
    
    public string Instructions { get; }

    public Color Color { get; }

    public Material Material { get; }

    public Position Home { get; private set; }

    public Position Position
    {
        get;
        set => field = Position.Wrap(value, Material.Size);
    }

    public Position Offset { get; }

    public Strand(Material material, string instructions, Color color, Position position, Position offset)
    {
        Instructions = instructions;
        Color = color;
        Material = material;
        Home = position;
        Position = position;
        Offset = offset;
    }

    // Runs one instruction. If we reach the end of the instructions, start
    // over at the beginning. If we reach the end and we're also back at
    // our home location, rehome the strand to a new location based on
    // the offset.
    public void RunNextInstruction()
    {
        char command = Instructions[NextInstruction];

        // RUBBLE: WEAVING THE AETHERS
        if (command == '>') { }
        if (command == '<') { }
        if (command == '^') { }
        if (command == 'v') { }
        if (command == '*') { /* RUBBLE: SHIELDING */ }
        if (command == ' ') { } // Do nothing.

        NextInstruction++;
        if (NextInstruction >= Instructions.Length)
        {
            NextInstruction -= Instructions.Length;

            if (Position == Home)
            {
                // Rehome the strand.
                Position = new Position(Position.Row + Offset.Row, Position.Column + Offset.Column);
                Home = Position;
            }
        }
    }
}

// Represents a position within a material, with a row and column.
public record Position(int Row, int Column)
{
    // Wraps the given location to a particular size.
    // If, for example, the size is 20, and the position is at (22, 24),
    // this will be wrapped so that the returned position is (2, 4).
    public static Position Wrap(Position position, int size)
    {
        // RUBBLE: WRAPPED UP
        return new Position((position.Row + size) % size, (position.Column + size) % size);
    }
}

// Represents a color value.
public record Color(byte R, byte G, byte B);

// A set of predefined colors. (You'll add more later.)
public static class Colors
{
    public static Color White { get; } = new Color(255, 255, 255);
    public static Color Black { get; } = new Color(0, 0, 0);

    // RUBBLE: WEAVING THE AETHERS
}