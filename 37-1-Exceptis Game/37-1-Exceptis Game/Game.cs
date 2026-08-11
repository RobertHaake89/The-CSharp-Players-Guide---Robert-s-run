using System;

namespace ExceptisGame;

class Game
{
    public static void MainLoop(Player player1, Player player2, NumberCollector numCollector)
    {
        Console.ForegroundColor = ConsoleColor.Green;

        bool isRunning = true;
        while (isRunning)
        {
            Console.Clear();
            Display.Header(numCollector);

            player1.GuessNumber(numCollector);
            if (player1.CheckForWinning()) break;

            player2.GuessNumber(numCollector);
            if (player2.CheckForWinning()) break;
        }
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("\n\tGAME OVER!\n");
        Console.ResetColor();
    }
}