using System;

namespace TicTacToe;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n\n\t\tROBERT'S TIC TAC TOE\n\n");

        Board board = new Board();

        Player player1 = new Player(Actor.Human, SqCondition.O);
        Player player2 = new Player(Actor.AI, SqCondition.X);

        GameController.MainLoop(player1, player2, board);
    }
}
