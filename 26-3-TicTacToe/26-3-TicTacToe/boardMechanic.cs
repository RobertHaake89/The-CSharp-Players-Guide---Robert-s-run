using System;

namespace TicTacToe;

internal class BoardMechanic
{
    internal static string[,] Grid()
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

        return grid;
    } 
}
