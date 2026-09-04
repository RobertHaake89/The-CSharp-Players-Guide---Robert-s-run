using System;

namespace CeruleanForge;

// Represents a color value.
public record Color(byte R, byte G, byte B);

// A set of predefined colors. (You'll add more later.)
public static class Colors
{
    public static Color White { get; } = new Color(255, 255, 255);
    public static Color Black { get; } = new Color(0, 0, 0);
    public static Color Cerulean { get; } = new Color(0, 148, 255);
    public static Color Azure { get; } = new Color(0, 63, 145);
    public static Color Amaranth { get; } = new Color(213, 24, 47);
    public static Color Coral { get; } = new Color(255, 127, 80);
    public static Color BurlyWood { get; } = new Color(222, 184, 135);
    public static Color LavenderBlush { get; } = new Color(255, 240, 245);
    public static Color Turquoise { get; } = new Color(64, 224, 208);
    public static Color BlueViolet { get; } = new Color(138, 43, 226);

    // RUBBLE: WEAVING THE AETHERS
}