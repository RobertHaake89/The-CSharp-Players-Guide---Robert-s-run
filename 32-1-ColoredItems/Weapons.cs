using System;
using System.Collections.Generic;

namespace Coloreditems;

enum ItemColor
{
    Red = 1,
    Green,
    Blue
}

class Sword
{
    //public string Name = "Sword";
}
class Bow
{
    //public string Name = "Bow";
}
class Axe
{
    //public string Name = "Axe";
}

class ColoredItem<T>
{
    public T? _item {get; set;}
    public ConsoleColor _color {get; set;}
    
    public ColoredItem(T item, ConsoleColor color)
    {
        _item = item;
        _color = color;
    }

    public void Display()
    {
        ConsoleColor color = _color;
        Console.ForegroundColor = color;

        string output = _item.ToString();
        Console.WriteLine(output);

        Console.ResetColor();
    }
}