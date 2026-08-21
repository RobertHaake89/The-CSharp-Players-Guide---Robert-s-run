using System;

namespace PotionMastersOfPattren;

public enum PotionType
{
    Empty = 0,
    Water,
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
}