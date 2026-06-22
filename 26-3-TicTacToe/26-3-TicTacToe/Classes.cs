using System;
using System.Xml.Serialization;
using Microsoft.VisualBasic;

namespace TicTacToe;

enum Mark
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
    internal string[,] Grid {get; set;} = // blank
        {
            { {One}, b, b },
            { b, b, b },
            { b, b, b },
        };
}

internal class Square
{
    internal Mark One {get; set;} = Mark.Empty;
    internal Mark Two {get; set;} = Mark.Empty;
    internal Mark Three {get; set;} = Mark.Empty;
    internal Mark Four {get; set;} = Mark.Empty;
    internal Mark Five {get; set;} = Mark.Empty;
    internal Mark Six {get; set;} = Mark.Empty;
    internal Mark Seven {get; set;} = Mark.Empty;
    internal Mark Eight {get; set;} = Mark.Empty;
    internal Mark Nine {get; set;} = Mark.Empty;
}

internal class Player
{
    internal Actor Actor {get;}
    internal Mark? Choice {get; set;} = null;
    internal int Rounds {get; set;} = 1;

    internal Player(Actor actor)
    {
        Actor = actor;
    }
}
