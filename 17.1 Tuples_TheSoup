using System;

namespace Tuples;

class Soup
{
    static void Main()
    {
        Console.WriteLine("SIMULA'S SOUPS\n");
        
        /*MENU CARD*/
        Console.WriteLine("1 - Garlic-Mushroom Stew");
        Console.WriteLine("2 - Cayenne-Carrot Soup");
        Console.WriteLine("3 - Ginger-Potatoes Curry");
        Console.WriteLine("4 - Cayenne-Chicken Curry");
        Console.WriteLine("5 - Garlic-Chicken Soup");
        Console.WriteLine("6 - Ginger-Carrots Stew");
        
        Console.WriteLine("\nWhat Soup do you want?");

        /*Recipe Tuple*/
        int input = Convert.ToInt32(Console.ReadLine());
        
        (Seasoning seasoning, Ingredient ingredient, Form form) soup = input switch // var soup = input switch would be shorter!
        {
            1 => (seasoning: Seasoning.Garlic, ingredient: Ingredient.Mushroom, form: Form.Stew),
            2 => (seasoning: Seasoning.Cayenne, ingredient: Ingredient.Carrot, form: Form.Soup),
            3 => (seasoning: Seasoning.Ginger, ingredient: Ingredient.Potato, form: Form.Curry),
            4 => (seasoning: Seasoning.Cayenne, ingredient: Ingredient.Chicken, form: Form.Curry),
            5 => (seasoning: Seasoning.Garlic, ingredient: Ingredient.Chicken, form: Form.Soup),
            6 => (seasoning: Seasoning.Ginger, ingredient: Ingredient.Carrot, form: Form.Stew),
            _ => throw new Exception("Bad Input")
        };
        Console.WriteLine($"{soup.seasoning}-{soup.ingredient} {soup.form}");

        /*SOUP VARIABLE*/
        Console.WriteLine("The destined Dish is:\n");
        Console.WriteLine($"{soup.seasoning}-{soup.ingredient} {soup.form}");


    }
}

enum Form
{
    Soup,
    Stew,
    Curry
}

enum Ingredient
{
    Mushroom,
    Chicken,
    Carrot,
    Potato
}

enum Seasoning
{
    Garlic,
    Cayenne,
    Ginger
}

