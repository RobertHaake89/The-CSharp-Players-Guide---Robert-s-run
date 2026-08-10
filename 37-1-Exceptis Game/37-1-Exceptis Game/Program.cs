using System;

namespace ExceptisGame;

class Program
{
    public static void Main()
    {
        Console.WriteLine("\n\tEXCEPTI'S GAME\n\n");

        var player1 = new Player("Player 1");
        var player2 = new Player("Player2");
        var collector1 = new NumberCollector();

        Game.MainLoop(player1, player2, collector1);
    }
}