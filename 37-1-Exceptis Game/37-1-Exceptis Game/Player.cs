using System;
using System.Linq;
using System.Threading;

namespace ExceptisGame;

abstract class Player
{
    public string? Name {get; init;}
    protected int _chosenNumber {get; set;}
    public bool IsWinner {get; set;} = false;
    private protected const int _sleepTimer = 3000;

    public Player(string name)
    {
        Name = name;
    }

    public virtual void GuessNumber(NumberCollector numCollector)
    {
        
        while (true)
        {
            Console.Clear();
            Display.Header(numCollector);

            Console.Write($"\n\n{Name}, please guess a Number [1-9]: ");
            
            try
            {
                _chosenNumber = int.Parse(Console.ReadLine()!);
            }
            catch (ArgumentNullException)
            {
                //_chosenNumber = 0;
                Console.Write("\nPlease enter a number: ");
                Thread.Sleep(_sleepTimer);
                continue;
            }
            catch (FormatException)
            {
                //_chosenNumber = 0;
                Console.WriteLine("\nThat's not a valid number!");
                Thread.Sleep(_sleepTimer);
                continue;
            }
            catch (OverflowException)
            {
                //_chosenNumber = 0;
                Console.WriteLine("\nThat number is far too big!");
                Thread.Sleep(_sleepTimer);
                continue;
            }

            if (_chosenNumber <= 0 || _chosenNumber >= 10)
            {
                Console.WriteLine("\nInvalid range!");
                Thread.Sleep(_sleepTimer);
                continue;
            }
            
            Console.WriteLine($"{Name} has chosen: {_chosenNumber}");

            if (numCollector.GetSecretNumber() == _chosenNumber)
            {
                Console.WriteLine($"\n{Name} has found the secret number!");
                IsWinner = true;
                Thread.Sleep(_sleepTimer);
                break;
            }
            else if (numCollector.GetSecretNumber() != _chosenNumber)
            {
                numCollector.AddNumber(_chosenNumber);
                Thread.Sleep(_sleepTimer);
                break;
            }
            else break;
        }
    }

    public bool CheckForWinning()
    {
        if (IsWinner) return true;
        else return false;
    }
}

class Human(string name) : Player(name)
{
    
}

class AI(string name) : Player(name)
{
    public override void GuessNumber(NumberCollector numCollector)
    {
        while (true)
        {
            Console.Write($"\n{Name} is thinking: ");

            for (int i = 1; i < 8; i++)
            {
                Console.Write(". ");
                Thread.Sleep(500);
            }
            Thread.Sleep(500);

            while (true)
            {
                _chosenNumber = Random.Shared.Next(1,10);

                bool hasAlreadyBeenChosen 
                    = numCollector.GetContent().Contains(_chosenNumber) 
                        ? true
                        : false;

                if (!hasAlreadyBeenChosen) break;
            }
            
            Console.WriteLine($"\n{Name} has chosen: {_chosenNumber}");

            if (numCollector.GetSecretNumber() == _chosenNumber)
            {
                Console.WriteLine($"\n{Name} has found the secret number!");
                IsWinner = true;
                Thread.Sleep(_sleepTimer);
                break;
            }
            else if (numCollector.GetSecretNumber() != _chosenNumber)
            {
                numCollector.AddNumber(_chosenNumber);
                Thread.Sleep(_sleepTimer);
                break;
            }
        }
    }
}