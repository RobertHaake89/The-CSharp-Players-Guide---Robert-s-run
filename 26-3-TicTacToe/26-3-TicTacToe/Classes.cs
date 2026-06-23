using System;

namespace TicTacToe;

enum SqCondition
{
    Empty = 0,
    O,
    X
}
enum Actor
{
    Human = 1,
    AI
}

internal class Board
{
    internal Square[,] Grid {get; set;}
    
    internal Board()
    {
        Grid = new Square[3, 3];

        for (int r = 0; r < 3; r++)
        {
            for (int c = 0; c < 3; c++)
            {
                Grid[r, c] = new Square();
            }
        }
    }
}

internal class Square
{
    internal SqCondition SqCondition {get; set;} = SqCondition.Empty;   
}

internal class Player
{
    internal Actor Actor {get; init;}
    internal SqCondition Mark {get; init;}
    internal Square? Choice {get; set;} = null;
    internal int Wins {get; set;} = 0;

    internal Player(Actor actor, SqCondition mark)
    {
        Actor = actor;
        Mark = mark;
    }

    internal Square GetPlayerChoice(Board board)
    {
        int playerInput = 0;

        if (Actor == Actor.Human) playerInput = Convert.ToInt32(Console.ReadLine());
        else if (Actor == Actor.AI) playerInput = Random.Shared.Next(1,10);

        Square Choice = playerInput switch
        {
            1 => board.Grid [0,2],
            2 => board.Grid[1,2],
            3 => board.Grid[2,2],
            4 => board.Grid[0,1],
            5 => board.Grid[1,1],
            6 => board.Grid[2,1],
            7 => board.Grid[0,0],
            8 => board.Grid[1,0],
            9 => board.Grid[2,0],
            _ => throw new Exception("Bad Input")
        };

        return Choice;
    }
}
