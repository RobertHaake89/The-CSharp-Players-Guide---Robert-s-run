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
        // Console.WriteLine(result);

        string name = result.ToString();
        //Console.WriteLine(name);

        var ingredient = new Ingredient(name, result);

        Console.WriteLine($"IngName:{ingredient.Name}     IngType:{ingredient.Type}");
        //Console.ReadKey();

        Ingredient = ingredient;
    }

    public void CreatePotion(AlchemistTable alchemistTable)
    {
        alchemistTable.SetSlotPotion(this);
        alchemistTable.SetSlotIngredient(this);

        alchemistTable.BrewPotion();
    }
}