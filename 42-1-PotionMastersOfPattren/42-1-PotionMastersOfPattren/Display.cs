using System;

namespace PotionMastersOfPattren;

class Display
{
    public static void MainScreen(Player player)
    {
        Console.WriteLine($"""
        =============================================
                        INGREDIENTS

            1 - Stardust                        O
            2 - Venom                         o
            3 - Dragon Breath               ___°
            4 - Shadow Glass               \   /
            5 - Eye Shine Gem              /   \
                                          /     \
                                         /       \
                                        |  1 > 3  |
                    PLAYER INVENTORY    |  1 > 4  |
                                        |  5 > 1  |
        Potion: {player.Potion.Name,-24}|_________|       
        Ingredient: {player.Ingredient.Name}
        =============================================
        """);
    }
}