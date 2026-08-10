using System;

namespace ExceptisGame;

class Player(string name)
{
    public string? Name {get; init;}
    private int[] _chosenNumbers {get; set;} = new int[10];

    /*public void AddNumber(int input)
    {
        int i = 0;

        for (; i <= _chosenNumbers.GetLength(0); i++)
        {
            if (_chosenNumbers[i] == 0)
            {
                _chosenNumbers[i] = input;

            }
            else i++;
        }
    }*/
}