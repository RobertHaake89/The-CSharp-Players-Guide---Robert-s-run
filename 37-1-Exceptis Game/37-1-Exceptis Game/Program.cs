using System;

namespace ExceptisGame;

class Program
{
    public static void Main()
    {
        var player1 = new Human("Player 1");
        var player2 = new AI("BOT");
        var collector1 = new NumberCollector();

        Game.MainLoop(player1, player2, collector1);
    }
}