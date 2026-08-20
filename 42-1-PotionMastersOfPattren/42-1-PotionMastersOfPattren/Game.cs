using System;

namespace PotionMastersOfPattren;

class Game
{
    public static void MainLoop(Player player, AlchemistTable alchemistTable)
    {


        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();

            Console.Write("Chose an ingredient: ");
            int numIngredient = int.Parse(Console.ReadLine());
            player.GetIngredient(numIngredient);

            //Console.WriteLine($"Potion: {player.Potion.Name}, Ingredient: {player.Ingredient.Name}");
            //Console.ReadKey();

            player.CreatePotion(alchemistTable);
            player.TakePotion(alchemistTable);

            Console.WriteLine($"{player.Name} has created a {player.Potion.Name} Potion!");

            Console.ReadKey();
            


        }
    }
}