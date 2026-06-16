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
}

