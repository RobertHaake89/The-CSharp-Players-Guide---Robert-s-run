using System;

namespace RockPaperScissor;

internal class GameController
{
    internal static void GameLoop(Player player1, Player player2)
    {
        while (true)
        {
            Player.GetMove(player1.Actor);
            Player.GetMove(player2.Actor);
            
            Methods.ShakingFist();
        }
    }
}
