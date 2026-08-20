using System;

namespace PotionMastersOfPattren;

class Program
{
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n\t\tTHE POTION MASTERS OF PATTREN\n\n");

        var player = new Player("Player");
        var potion = new Potion(PotionType.Water);

        var alchemistTable = new AlchemistTable();

        player.Potion = potion;

        Game.MainLoop(player, alchemistTable);
    }
}
