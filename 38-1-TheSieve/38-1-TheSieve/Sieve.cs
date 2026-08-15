using System;

namespace TheSieve;

public class Sieve
{
    private int _number {get; set;}
    private bool _isTrue {get; set;}

    public int GetNumber() => _number;
    public int SetNumber(int input) => _number = input;

    public bool GetCondition() => _isTrue;
    public bool SetCondition(Delegate.SieveDelegate chosenCheck) => _isTrue = chosenCheck(this);
}