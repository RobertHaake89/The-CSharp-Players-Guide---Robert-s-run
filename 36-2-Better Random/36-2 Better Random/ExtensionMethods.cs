using System;

namespace BetterRandom;

public static class ExtensionFormatting
{
    public static string ToTitleCase(this string text)
    {
        char[] letters = text.ToCharArray();

        for (int index = 0; index < letters.Length; index++)
            if (index == 0 || letters[index -1] == ' ')
                letters[index] = char.ToUpper(letters[index]);

        return new string(letters);
    }

    public static double TrimDouble(this double input) => Math.Round(input, 5);
}

public static class ExtensionMethod
{
    enum HeadChance
        {
            Zero = 0,
            TwentyFive = 25,
            Fifty = 50,
            SeventyFive = 75,
        }
    public static double RandomDouble(this double input) => Random.Shared.NextDouble() * 10;
    
    public static string RandomDirection(this string direction)
    {
        int randomNumber = Random.Shared.Next(1,5);

        direction = randomNumber switch
        {
            1 => "up",
            2 => "down",
            3 => "left",
            4 => "right",
            _ => "no answer.."
        };

        return direction;
    }

    public static string TossCoin(this bool isHead)
    {
        double randomizer = Random.Shared.Next(1,11);
        double headFactor;

        if (randomizer % 3 == 0) headFactor = (double)HeadChance.TwentyFive / 100;
        else if (randomizer % 2 == 0) headFactor = (double)HeadChance.Fifty / 100;
        else if (randomizer % 5 == 0) headFactor = (double)HeadChance.SeventyFive / 100;
        else headFactor = (double)HeadChance.Zero / 100;


        Console.WriteLine(headFactor);
        isHead = Math.Round(headFactor) == 1;

        string result = isHead ? "head" : "tail";

        return result;
    }
}