using System;

namespace PotionMastersOfPattren;

class Display
{
    public static void MainScreen(Player player)
    {
        Console.WriteLine($"""
        =================================
                  INGREDIENTS

        1 - Stardust
        2 - Venom
        3 - Dragon Breath
        4 - Shadow Glass
        5 - Eye Shine Gem

               PLAYER INVENTORY

        Potion: {player.Potion.Name}
        Ingredient: {player.Ingredient.Name}
        ==================================
        """);
    }
}