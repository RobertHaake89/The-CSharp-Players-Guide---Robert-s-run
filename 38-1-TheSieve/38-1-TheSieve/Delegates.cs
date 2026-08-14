using System;

namespace TheSieve;

public class Delegate
{
    public delegate bool SieveDelegate(int number);

    static bool CheckEven(int number)
    {
        if (number % 2 == 0) return true;
        else return false;
    }
    static bool CheckPositive(int number)
    {
        if (number >= 0) return true;
        else return false;
    }
    static bool CheckMultipleTen(int number)
    {
        if (number % 10 == 0) return true;
        else return false;
    }
SieveDelegate even = CheckEven;
    SieveDelegate positive = CheckPositive;
    SieveDelegate multipleTen = CheckMultipleTen;
}
    