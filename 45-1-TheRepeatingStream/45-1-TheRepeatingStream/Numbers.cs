using System;
using System.Threading;

namespace TheRepeatingStream;

public static class RecentNumbers
{
    private static List<int>? _numberMemory {get; set;} = new List<int>(MaxLoops) {0,0};
    private static List <int> _evenNumber = new List<int>(MaxLoops);
    private static List <int> _oddNumber = new List<int>(MaxLoops);
    private static int _counter {get; set;} = 0;
    public static readonly int MaxLoops = 100_000;

    private static readonly Lock _lock1 = new();

    public static int GetMemory()
    {
        return _numberMemory![_counter];
    }

    public static List<int> GetEvenNumber() => _evenNumber;
    public static List<int> GetOddNumber() => _oddNumber;

    public static int GetCounter() => _counter;

    public static void ThreadingProcess()
    {
        int number = Methods.GenerateRandomNumber();

        lock (_lock1)
        {
            _numberMemory!.Add(number);

            try
            {
                if (_counter % 2 == 0)
                {
                    _evenNumber.Add(_counter);
                }
                else if (_counter % 2 != 0)
                {
                    _oddNumber.Add(_counter);
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine($"Null Error: {e}");
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"Overflow Exception: {e}");
            }
            catch (OutOfMemoryException e)
            {
                Console.WriteLine($"OutOfMemory Exception: {e}");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"Number too large: {e}");
            }
            finally
            {
                _counter++;
            }

            Console.Write($"{_counter} ");
        }
    }
}