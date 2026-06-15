using System;

namespace RockPaperScissor;

internal class Methods
{
    internal static void ShakingFist()
    {
        int shakingSpeed = 150; // 200 default

        for (int i = 0; i < 6; ++i)
        {
            if (i % 2 == 0) Console.WriteLine("\n"); // Modulo-Controlled Line for Shaking Effect
            
            //Display.Hand.Dual.FistShake();
            Display.Hand.Left.Fist();
            Display.Hand.Right.Fist();

            Thread.Sleep(shakingSpeed);
            Console.Clear();
        }
    }
}