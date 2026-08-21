using System;
using System.Threading;

namespace PotionMastersOfPattren;

class AlchemistTable
{
    private Potion? _brewedPotion {get; set;}
    private Potion? _slotPotion {get; set;}
    private Ingredient? _slotIngredient {get; set;}

    public void ReleasePotion(out Potion result)
    {
        if (_brewedPotion == null) result = null!;
        else result = _brewedPotion;
        
        _brewedPotion = null;
    }
    
    public void SetSlotPotion(in Player player)
    {
        _slotPotion = player.Potion;
        player.Potion = null;

        player.Potion = new Potion(PotionType.Empty);
    }

    public void SetSlotIngredient(in Player player)
    {
        _slotIngredient = player.Ingredient;
        player.Ingredient = null;

        player.Ingredient = new Ingredient(IngredientType.None);
    }
    
    public void BrewPotion()
    {
        PotionType potionType = (_slotPotion!.Type, _slotIngredient!.Type) switch
        {
            // Elixir
            (PotionType.Water, IngredientType.Stardust)
            => PotionType.Elixir,
            // Poison
            (PotionType.Elixir, IngredientType.Venom)
            => PotionType.Poison,
            // Fyling
            (PotionType.Elixir, IngredientType.DragonBreath)
            => PotionType.Flying,
            // Invisibility
            (PotionType.Elixir, IngredientType.ShadowGlass)
            => PotionType.Invisibility,
            // Nightsight
            (PotionType.Elixir, IngredientType.EyeshineGem)
            => PotionType.NightSight,
            // Cloudy Brew
            (PotionType.NightSight, IngredientType.ShadowGlass)
            => PotionType.Cloudy,
            (PotionType.Invisibility, IngredientType.EyeshineGem)
            => PotionType.Cloudy,
            // Wraith
            (PotionType.Cloudy, IngredientType.Stardust)
            => PotionType.Wraith,
            _ => PotionType.Ruined
        };

        string loadPoint = ". ";

        Console.Write("\nBrewing: ");
        for (int i = 0; i < 12; i++)
        {
            Console.Write($"{loadPoint} ");
            Thread.Sleep(500);
        }

        _brewedPotion = new Potion(potionType);
    }
}