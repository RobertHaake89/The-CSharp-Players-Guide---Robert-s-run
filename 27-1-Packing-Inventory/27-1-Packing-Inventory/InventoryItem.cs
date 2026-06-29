using System;
using System.Collections.Generic;

namespace PackingInventory;

public abstract class Item
{
    public string Name {get;}
    public float Weight {get;}
    public float Volume {get;}

    public Item(string name, float weight, float volume)
    {
        Name = name;
        Weight = weight;
        Volume = volume;
    }
}

class Sword : Item
{
    public Sword() : base("Sword", 5f, 3f)
    {
        
    }
}

class Bow : Item
{
    public Bow() : base("Bow", 1f ,4f)
    {
        
    }
}

class Arrow : Item
{
    public Arrow() : base("Arrow", 0.1f, 0.05f)
    {
        
    }
}

class Rope : Item
{
    public Rope() : base("Rope", 1f, 1.5f)
    {
        
    }
}

class Water : Item
{
    public Water() : base("Water", 2f, 3f)
    {
        
    }
}

class FoodRation : Item
{
    public FoodRation() : base("Food Ration", 1f, 0.5f)
    {
        
    }
}
