using System;

namespace RockPaperScissor;

internal class GameController
{
    internal static void GameLoop(Player player1, Player player2)
    {
        while (true)
        {
            player1.Move = Methods.GetMove(player1.Actor);
            player2.Move = Methods.GetMove(player2.Actor);
            
            Methods.ShakingFist();

        }
    }
}
