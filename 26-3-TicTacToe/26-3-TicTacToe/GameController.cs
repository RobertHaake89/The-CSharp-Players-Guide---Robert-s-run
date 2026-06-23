using System;

namespace TicTacToe;

internal class GameController
{
    internal static void MainLoop(Player player1, Player player2, Board board)
    {
        while (true)
        {
            Console.Write("Chose your Square: ");
            Square player1Move = player1.GetPlayerChoice(board);
            Square player2Move = player2.GetPlayerChoice(board);

            Display.GridDisplay(player1Move, player2Move);
        }
    }
}
