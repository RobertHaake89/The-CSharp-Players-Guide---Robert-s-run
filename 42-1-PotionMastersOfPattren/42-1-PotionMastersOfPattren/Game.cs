using System;
using System.Threading;

namespace PotionMastersOfPattren;

class Game
{
    public static void MainLoop(ref Player player, ref AlchemistTable alchemistTable)
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Display.MainScreen(player);

            Console.Write("Chose an ingredient: ");
            int numIngredient = int.Parse(Console.ReadLine()!);
            player.GetIngredient(numIngredient);

            Console.Clear();
            Display.MainScreen(player);

            player.CreatePotion(alchemistTable);

            Console.Clear();
            Display.MainScreen(player);

            player.TakePotion(alchemistTable);

            Method.VovelChecker(player, out string addN);
            Console.WriteLine($"\n\n{player.Name} has created a{addN} {player.Potion.Name} Potion!");

            player.DiscardRuinedPotion();

            //Console.ReadKey();
            Thread.Sleep(4000);
        }
    }
}