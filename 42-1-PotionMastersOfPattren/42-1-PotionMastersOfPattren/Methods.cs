using System;

namespace PotionMastersOfPattren;

class Method
{
    public static void VovelChecker(Player player, out string addN)
    {
        char[] chars = player.Potion.Name.ToArray();
        
        addN 
        = chars[0].ToString() is "A" or "E" or "I" or "O" or "U" 
            ? "n" 
            : "";
    }
}