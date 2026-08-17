using System;

namespace CharberryTrees;

class CharberryTree
{
    private Random _random = new Random();
    public bool Ripe {get; set;}

    public void MaybeGrow()
    {
        if (_random.NextDouble() < 0.00000001 && !Ripe) Ripe = true;
    }
}