using System;

namespace PotionMastersOfPattren;

public enum IngredientType
{
    None,
    Stardust = 1,
    Venom,
    DragonBreath,
    ShadowGlass,
    EyeshineGem
}

class Ingredient(string name, IngredientType type)
{
    public string? Name {get; set;} = name;
    public IngredientType Type {get; set;} = type;
}
