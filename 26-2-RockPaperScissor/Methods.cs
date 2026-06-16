using System;
using System.ComponentModel;
using Microsoft.VisualBasic;

namespace RockPaperScissor;

internal class Methods
{
    internal static int GetMove(Actor actor)
    {
        if (actor == Actor.Human)
        {
            Console.Write("Your Turn!\nRock (1), Paper (2), Scissor (3): ");
            return Convert.ToInt32(Console.ReadLine());
        }
        else if (actor == Actor.AI)
        {
            return Random.Shared.Next(1, 4);
        }
        else return 0;
    }


    internal static int MatchingMoves(Player move, Player wins)
    {
        if (player1.move == player2.move)
        {
            return Player.wins = Player.wins + 0;
        }
    }
}