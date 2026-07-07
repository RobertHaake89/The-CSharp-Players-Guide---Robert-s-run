using System;

namespace WarPreparations;

class Program
{
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\t\tWAR PREPARATIONS\n\n");

        Sword sword1 = new Sword("Sword One",Material.Iron,Gemstone.None,102.5f,15.7f);

        Sword sword2 = sword1 with {_name = "Sword 2", _material = Material.Wood, _gemstone = Gemstone.Emerald};

        Sword sword3 = sword1 with
        {_name = "Sword 3",
        _material = Material.Binarium,
        _gemstone = Gemstone.Bitstone,
        _length = 140.3f,
        _crossGuardWidth = 20.4f};

        Console.WriteLine($"{sword1._name} is made of {sword1._material} and has a {sword1._gemstone} Gem attached to it.");
        Console.WriteLine($"Its Length is about {sword1._length}\" and the Cross Guard meassures {sword1._crossGuardWidth} in Width.\n");
        Console.WriteLine($"{sword2._name} is made of {sword2._material} and has a {sword2._gemstone} Gem attached to it.");
        Console.WriteLine($"Its Length is about {sword2._length}\" and the Cross Guard meassures {sword2._crossGuardWidth} in Width.\n");
        Console.WriteLine($"{sword3._name} is made of {sword3._material} and has a {sword3._gemstone} Gem attached to it.");
        Console.WriteLine($"Its Length is about {sword3._length}\" and the Cross Guard meassures {sword3._crossGuardWidth} in Width.\n");
          
        
    }
}
