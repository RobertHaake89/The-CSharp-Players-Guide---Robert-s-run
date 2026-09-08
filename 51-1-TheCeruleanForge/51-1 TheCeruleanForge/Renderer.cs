using System;

namespace CeruleanForge;

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
                RenderConsoleLocation(new Position(row, column));
            }
            Console.WriteLine();
        }
    }

    // Renders the character at a given row and column, figuring out what the 
    // colors should be for the top (background) and bottom (foreground) halves.
    public void RenderConsoleLocation(Position position)
    {
        int consoleRow = position.Row / 2;

        Color? topHalf = _material.GetData(consoleRow * 2, position.Column);
        Color? bottomHalf = _material.GetData(consoleRow * 2 + 1, position.Column);

        if (consoleRow >= Console.BufferHeight ||
        position.Column >= Console.BufferWidth)
        return;

        Console.SetCursorPosition(position.Column, consoleRow);
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