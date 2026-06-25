using System;

namespace PackingInventory;

internal class Item
{
    private float _weight {get; set;}
    private float _volume {get; set;}

    public Item(float weight, float volume)
    {
        _weight = weight;
        _volume = volume;
    }
}

internal class Arrow : Item
{
    public Arrow() : base(0.1f, 0.05f)
    {
        
    }
}

internal class Bow : Item
{
    public Bow() : base(1f, 4f)
    {
        
    }
}

internal class Rope : Item
{
    public Rope() : base(1f, 1.5f)
    {
        
    }
}

internal class Water : Item
{
    public Water() : base(2f, 3f)
    {
        
    }
}

internal class FoodRation : Item
{
    public FoodRation() : base(1f, 0.5f)
    {
        
    }
}

internal class Sword : Item
{
    public Sword() : base(5f, 3f)
    {
        
    }
}