using System;

namespace RockPaperScissor;

internal class GameController
{
    internal static void GameLoop()
    {
        var player1 = new Player(Actor.Human, 0, 0);
        var player2 = new Player(Actor.AI, 0, 0);

        Console.Write("\nHow many Wins: ");
        int maxWinnings = Convert.ToInt32(Console.ReadLine());

        Console.Clear();
        
        int gameRound = 0;

        while (player1.Wins < maxWinnings && player2.Wins < maxWinnings)
        {
            gameRound++;

            player1.Move = Methods.GetMove(player1.Actor);
            player2.Move = Methods.GetMove(player2.Actor);
            
            Display.Hand.Dual.ShakingFists();

            Methods.ShowEnemyMove(player2);

            Methods.MatchingMoves(player1, player2);

            Console.WriteLine($"{player1.Actor} has {player1.Wins} Wins and {player2.Actor} has {player2.Wins} Wins!");
            Thread.Sleep(5000);
            Console.Clear();
        }

        string winner;

        if (player1.Wins == maxWinnings)
        {
            winner = Convert.ToString(player1.Actor);
        }
        else
        {
            winner = Convert.ToString(player2.Actor);
        }

        Console.WriteLine($"\n\n\t\t{winner} is the Winner!");
        Console.ReadKey();
    }
}
