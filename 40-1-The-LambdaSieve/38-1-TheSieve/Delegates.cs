using System;

namespace TheSieve;

public class Delegate
{
    public delegate bool SieveDelegate(Sieve sieve);

    public static bool CheckEven(Sieve sieve)
    {
        if (sieve.GetNumber() % 2 == 0) return true;
        else return false;
    }
    public static bool CheckPositive(Sieve sieve)
    {
        if (sieve.GetNumber() >= 0) return true;
        else return false;
    }
    public static bool CheckMultipleTen(Sieve sieve)
    {
        if (sieve.GetNumber() % 10 == 0) return true;
        else return false;
    }

    /*SieveDelegate even = CheckEven;
    SieveDelegate positive = Delegate.CheckPositive;
    SieveDelegate multipleTen = Delegate.CheckMultipleTen;*/
}
    