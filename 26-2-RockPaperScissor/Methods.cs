using System;
using Microsoft.VisualBasic;

namespace RockPaperScissor;

internal class Methods
{
    internal static Move GetMove(Actor actor)
    {
        if (actor == Actor.Human)
        {
            Console.Write("\nYour Turn!\n\nRock (1), Paper (2), Scissor (3): ");
            Move move = (Move)Convert.ToInt32(Console.ReadLine());
            return move;
        }
        else if (actor == Actor.AI)
        {
            Move move = (Move)Random.Shared.Next(1, 4);
            return move;
        }
        else return 0;
    }

    internal static void ShowEnemyMove(Player player2)
    {
        switch (player2.Move)
        {
            case Move.Rock:
                Display.Hand.Right.Rock();
                break;
            
            case Move.Paper:
                Display.Hand.Right.Paper();
                break;
            
            case Move.Scissor:
                Display.Hand.Right.Scissor();
                break;
            
            default:
                Console.WriteLine("Bad Input");
                break;
        }
    }


    internal static int? MatchingMoves(Player player1, Player player2)
    {
        bool isTrump = false;

        if (player1.Move == player2.Move) // TIE
        {
            Console.WriteLine("TIE!");
            return null;
        }
        else if (player1.Move == Move.Rock && player2.Move == Move.Scissor)
        {
            isTrump = true;
        }
        else if (player1.Move == Move.Paper && player2.Move == Move.Rock)
        {
            isTrump = true;
        }
        else if (player1.Move == Move.Scissor && player2.Move == Move.Paper)
        {
            isTrump = true;
        }

        if (isTrump)
        {
            return player1.Wins++;
        }
        else
        {
            return player2.Wins++;
        }
    }
}