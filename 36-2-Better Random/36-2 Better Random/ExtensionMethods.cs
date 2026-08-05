using System;
using System.Collections;
using System.IO.Pipelines;
using System.Runtime.CompilerServices;

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

    public static string TossCoin(this bool coin)
    {
        int coinSide = Random.Shared.Next(1,3);

        if (coinSide == 1) coin = true;
        else coin = false;

        string result = coin ? "head" : "tail";

        return result;
    }
}