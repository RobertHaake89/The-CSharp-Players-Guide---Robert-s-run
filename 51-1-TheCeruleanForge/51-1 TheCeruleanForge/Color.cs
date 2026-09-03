using System;

namespace CeruleanForge;

// Represents a color value.
public record Color(byte R, byte G, byte B);

// A set of predefined colors. (You'll add more later.)
public static class Colors
{
    public static Color White { get; } = new Color(255, 255, 255);
    public static Color Black { get; } = new Color(0, 0, 0);

    // RUBBLE: WEAVING THE AETHERS
}