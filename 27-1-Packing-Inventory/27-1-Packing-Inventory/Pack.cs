using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace PackingInventory;


public class Pack
{
    private List<Item> _storage {get; set;} = new();

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

    public void MainMenu()
    {
        Console.Clear();

        Console.Write($"""
        Your Backpack status:

        Quantity:   {_currentItemCount} / {_maxItemCount}
        Weight:     {_currentWeight} / {_maxWeight}
        Volume:     {_currentVolume} / {_maxVolume}

        Items: 
        """);

        Console.WriteLine(string.Join(", ", _storage.Select(item => item.Name))); // first use of LINQ
        // foreach (Item item in _storage) Console.Write($"{item.Name}, ");

        Console.WriteLine("\n\nWhat do you want do do?");
        Console.WriteLine("(1) Add Item (2) Remove Item (3) Move On");
    }
    
    public void Add()
    {
        Console.Clear();

        Item[] equipment = new Item[10];

        Item sword = new Sword();
        Item bow = new Bow();
        Item arrow = new Arrow();
        Item rope = new Rope();
        Item water = new Water();
        Item foodRation = new FoodRation();

        equipment[1] = sword;
        equipment[2] = bow;
        equipment[3] = arrow;
        equipment[4] = rope;
        equipment[5] = water;
        equipment[6] = foodRation;

        Console.Write("""

        1 - Sword       4 - Rope            7 - Return
        2 - Bow         5 - Water
        3 - Arrow       6 - Food Ration

        Enter Number: 
        """);

        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 7) return;

        bool isFull = 
        _currentItemCount >= _maxItemCount ||
        _currentWeight >= _maxWeight ||
        _currentVolume >= _maxVolume ?
        true : false;

        if (!isFull)
        {
            _storage.Add(equipment[choice]);
            _currentItemCount++;
            _currentWeight += equipment[choice].Weight;
            _currentVolume += equipment[choice].Volume;
        }
        else 
        {
            Console.WriteLine("\nWarning: Your Pack is already Full!");
            Thread.Sleep(2000);
        }
    }

    public void Remove() // UNSTABLE!
    {
        Console.Clear();

        Console.WriteLine(string.Join($", ", _storage.Select(item => item.Name)));

        Console.Write("What Item you want to remove (11 = return)? ");

        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice == 11) return;

        bool isEmpty = 
        _currentItemCount == 0 ||
        _currentWeight == 0 ||
        _currentVolume == 0 ?
        true : false;

        if (!isEmpty)
        {
            _storage.Remove(_storage[choice]);
            _currentItemCount--;
            _currentWeight -= _storage[choice].Weight;
            _currentVolume -= _storage[choice].Volume;
        }
        else 
        {
            Console.WriteLine("\nYour Pack is already Empty!");
            Thread.Sleep(2000);
        }
    }
}
