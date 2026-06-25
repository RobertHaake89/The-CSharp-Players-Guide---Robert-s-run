using System;

namespace PackingInventory;


public class Pack
{
    private List<Item>? _storage {get; set;}

    private int _maxItemCount {get; init;}
    private float _maxWeight {get; init;}
    private float _maxVolume {get; init;}

    private int _currentItemCount {get; set;} = 0;
    private float _currentWeight {get; set;} = 0;
    private float _currentVolume {get; set;} = 0;
    
    public Pack(int maxItemCount, float maxWeight, float maxVolume)
    {
        _maxItemCount = maxItemCount;
        _maxWeight = maxWeight;
        _maxVolume = maxVolume;
    }

    public void Overview(List<Item> item)
    {
        Console.Write($"""
        Your Backpack status:

        Quantity:   {_currentItemCount} / {_maxItemCount}
        Weight:     {_currentWeight} / {_maxWeight}
        Volume:     {_currentVolume} / {_maxVolume}

        Items: 
        """);

        foreach (Item item in items) Console.Write($"{item} ");
    }

    public void Add(Item item)
    {
        bool isFull = 
        _currentItemCount <= _maxItemCount &&
        _currentWeight <= _maxWeight &&
        _currentVolume <= _maxVolume ?
        false : true;

        if (!isFull)
        {
            ++_currentItemCount;
            _storage[_currentItemCount] = item;
            _currentWeight += item.Weight;
            _currentVolume += item.Volume;
        }
        else Console.WriteLine("Warning: Your Pack is already Full!");
    }
}
