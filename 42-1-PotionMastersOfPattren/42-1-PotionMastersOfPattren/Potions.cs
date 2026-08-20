using System;

namespace PotionMastersOfPattren;

public enum PotionType
{
    Water = 0,
    Elixir,
    Poison,
    Flying,
    Invisibility,
    NightSight,
    Cloudy,
    Wraith,
    Ruined
}

class Potion
{
    public string? Name {get; set;}
    public PotionType Type {get; set;} = PotionType.Water;

    public Potion(PotionType type)
    {
        Name = type.ToString();
        Type = type;
    }

    public void SetName() => Name = Type.ToString();
    //public void SetType(PotionType type) => Type = type;
}