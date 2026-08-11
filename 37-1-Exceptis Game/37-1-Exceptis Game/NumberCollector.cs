using System;

namespace ExceptisGame;

class NumberCollector
{
    private int[]? _collection {get; set;} = new int[10];
    private readonly int _sectretNumber = Random.Shared.Next(1,10);

    public int[] GetContent()
    {
        return _collection!;
    }

    public int GetSecretNumber()
    {
        return _sectretNumber;
    }

    public void AddNumber(int input)
    {
        int i = 0;

        for (; i < _collection!.GetLength(0); i++)
        {
            if (_collection[i] == input)
            {
            Console.WriteLine("\nThis number has already been chosen!");
            break;
            }
            else if (_collection[i] == 0)
            {
                _collection[i] = input;
                break;
            }
            
        }
    }

    public bool MatchWithSecretNumber(int chosenNumber)
    {
        int i = 0;

        for (; i < _collection!.GetLength(0); i++)
        {
            if (_sectretNumber == chosenNumber)
            {
            Console.WriteLine("BINGO!");
            return true;
            }
        }
        return false;
    }
}