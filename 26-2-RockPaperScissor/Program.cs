using System;
using Microsoft.VisualBasic;

namespace RockPaperScissor;

internal class Program
{
    private static void Main()
    {
        Console.WriteLine("ROBERT'S ROCK PAPER SCISSORS");

        var player1 = new Player(Actor.Human, 0 ,0);
        var player2 = new Player(Actor.AI ,0 ,0);

        GameController.GameLoop(player1, player2);
        
    }
}
