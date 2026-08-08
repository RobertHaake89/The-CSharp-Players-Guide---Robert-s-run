using System;
using System.ComponentModel.DataAnnotations;

namespace ExceptisGame;

class NumberCollector
{
    private int[]? _collection {get; set;} = new int[10];

    public void AddNumber(int input)
    {
        int i = 0;

        for (; i < this._collection!.GetLength(0); i++)
        {
            if (this._collection.Contains(input))
            {
            Console.WriteLine("This number has already been chosen!");
            break;
            }

            else if (this._collection[i] != 0)
            this._collection[i] += input;
        }
    }
}