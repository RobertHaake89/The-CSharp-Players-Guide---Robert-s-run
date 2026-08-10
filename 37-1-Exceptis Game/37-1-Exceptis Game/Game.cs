using System;
using Microsoft.VisualBasic;

namespace ExceptisGame;

class Game
{
    public static void MainLoop(Player player1, Player player2, NumberCollector numCollector)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        int input;

        bool isRunning = true;
        while (isRunning)
        {
            Console.Clear();

            Console.WriteLine("\n\t\tEXCEPTIS GAME\n\n");

            

            Console.Write($"{player1.Name} please guess a Number: ");
            input = int.Parse(Console.ReadLine());
            numCollector.AddNumber(player1, input);

            Console.Write($"{player2.Name} please guess a Number: ");
            input = int.Parse(Console.ReadLine());
            numCollector.AddNumber(player2, input);


        }
    }
}