using System;

namespace RockPaperScissor;

enum Actor
{
    Human = 1,
    AI
}
enum Move
{
    None = 0,
    Rock,
    Paper,
    Scissor
}

internal class Player
{
    internal Actor Actor {get; init;}
    internal int Move {get; set;}
    internal int Wins {get; set;}

    internal Player(Actor actor, int move, int wins)
    {
        Actor = actor;
        Move = move;
        Wins = wins;
    }

    internal static int GetMove(Actor actor)
    {
        int inputMove;

        if (actor  == Actor.Human)
        {
            Console.Write("Your Turn!\nRock (1), Paper (2), Scissor (3): ");
            inputMove = Convert.ToInt32(Console.ReadLine());
            return inputMove;
        }
        else if (actor == Actor.AI)
        {
            inputMove = Random.Shared.Next(1, 4);
            return inputMove;
        }
        else return inputMove = 0;
    }
}

