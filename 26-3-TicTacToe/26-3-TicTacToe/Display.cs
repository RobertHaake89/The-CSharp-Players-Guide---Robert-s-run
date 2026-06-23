using System;
using System.Runtime.CompilerServices;

namespace TicTacToe;

internal class Display
{
    internal static void GridDisplay(Square player1Move, Square player2Move)
    {

        string b = "[ ]"; // blank
        string o = "[O]";
        string x = "[X]";
        
        string[,] grid =
        {
            { b, b, b },
            { b, b, b },
            { b, b, b },
        };
        
        Console.WriteLine($"""
        -----------------
        |   | |   | |   |       7 - 8 - 9
        -----------------
        |   | |   | |   |       4 - 5 - 6
        -----------------
        |   | |   | |   |       1 - 2 - 3
        -----------------

        """);
    }
}
