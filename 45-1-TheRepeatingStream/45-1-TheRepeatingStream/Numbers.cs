using System;
using System.Globalization;
using System.Threading;

namespace TheRepeatingStream;

public static class RecentNumbers
{
    private static List<int>? _numberMemory {get; set;} = new List<int>() {0,0};
    private static int _counter {get; set;}
    public static int Counter {get; set;} = 0;

    public static readonly Lock _lock = new();
    

    public static int GetMemory() => _numberMemory![0];

    public static int GetCounter() => _counter;
    public static void SetCounter()
    {
        lock (_lock)
        {
            _counter++;
        }
    }

    public static void AddToMemory(int input)
    {
        lock (_lock)
        {
            int tempNumber = _numberMemory![0];

            _numberMemory[1] = tempNumber;
            _numberMemory[0] = input;
        }
    }

    
}