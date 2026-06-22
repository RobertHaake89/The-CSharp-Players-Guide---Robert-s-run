using System;

namespace TicTacToe;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n\n\t\tROBERT'S TIC TAC TOE\n\n");

        Board tictactoe = new Board();

        Player human = new Player(Actor.Human);
        Player ai = new Player(Actor.AI);

        GameController.MainLoop();
    }
}
