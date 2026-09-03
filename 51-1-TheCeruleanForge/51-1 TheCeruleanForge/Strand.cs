using System;

namespace CeruleanForge;

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
