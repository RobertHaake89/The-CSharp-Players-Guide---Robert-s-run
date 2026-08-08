using System;
using Microsoft.VisualBasic;

namespace ExceptisGame;

class Game
{
    private readonly int _sectretNumber = Random.Shared.Next(1,10);
    public static void MainLoop(Player player1, Player player2, NumberCollector numCollector)
    {
        Console.ForegroundColor = ConsoleColor.Green;

        bool isRunning = true;
        while (isRunning)
        {
            Console.Clear();


        }
    }
}