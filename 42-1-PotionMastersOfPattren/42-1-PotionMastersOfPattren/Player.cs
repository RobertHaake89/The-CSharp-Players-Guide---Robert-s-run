using System;

namespace PotionMastersOfPattren;

class Player
{
    public string? Name {get; init;}
    public Potion? Potion {get ; set;}
    public Ingredient? Ingredient {get; set;}

    public Player(string name)
    {
        Name = name;
    }

    public void TakePotion(AlchemistTable alchemistTable)
    {
        alchemistTable.ReleasePotion(out Potion result);
        Potion = result;
    }

    public void GetIngredient(int number)
    {
        IngredientType result = number switch
        {
            1 => IngredientType.Stardust,
            2 => IngredientType.Venom,
            3 => IngredientType.DragonBreath,
            4 => IngredientType.ShadowGlass,
            5 => IngredientType.EyeshineGem,
            _ => IngredientType.None
        };

        var ingredient = new Ingredient(result);

        Ingredient = ingredient;
    }

    public void CreatePotion(AlchemistTable alchemistTable)
    {
        alchemistTable.SetSlotPotion(this);
        alchemistTable.SetSlotIngredient(this);

        alchemistTable.BrewPotion();
    }

    public void DiscardRuinedPotion()
    {
        if (Potion!.Type is PotionType.Ruined)
        {
            Potion = new Potion(PotionType.Water);
            Console.WriteLine("\nYou discard the ruined Potion.");
        }
    }
}