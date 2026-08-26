using System;
using System.Threading;

namespace TheRepeatingStream;

public class Methods
{
    public static int GenerateRandomNumbers()
    {
        //int i = 0;
        int randomNumber;

        while (true)
        {
            randomNumber = Random.Shared.Next(1,10);
            Thread.Sleep(10);
            return randomNumber;
        }
    }
}