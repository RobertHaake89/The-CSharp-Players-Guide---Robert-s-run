using System;

namespace PotionMastersOfPattren;

public enum IngredientType
{
    None = 0,
    Stardust,
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
