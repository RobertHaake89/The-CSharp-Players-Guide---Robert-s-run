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

class Ingredient(IngredientType type)
{
    public string? Name {get; set;} = type.ToString();
    public IngredientType Type {get; set;} = type;
    
}
