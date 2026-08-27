using System;
using System.Globalization;
using System.Threading;

namespace TheRepeatingStream;

public static class RecentNumbers
{
    private static List<int>? _numberMemory {get; set;} = new List<int>(maxLoops) {0};
    public static List <int> EvenNumber = new List<int>(maxLoops);
    public static List <int> OddNumber = new List<int>(maxLoops);
    private static int _counter {get; set;} = 0;
    public static int Counter {get; set;} = _counter;
    public static int maxLoops = 500;

    public static readonly Lock _lock = new();
    

    public static int GetMemory() => _numberMemory![_counter];

    public static void AddToMemory(int input)
    {
        lock (_lock)
        {
            _numberMemory!.Add(input);
        }
    }

    public static int GetCounter() => _counter;
    public static void SetCounter()
    {
        lock (_lock)
        {
            //Console.Write(_counter);
            _counter++;
        }
    }

    

    
}