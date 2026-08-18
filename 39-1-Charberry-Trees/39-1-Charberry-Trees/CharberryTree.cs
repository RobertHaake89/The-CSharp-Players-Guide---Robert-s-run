using System;

namespace CharberryTrees;

public class CharberryTree
{
    private Random _random = new Random();
    public bool IsRipe {get; set;}
    public event EventHandler? Ripened;


    
    public void MaybeGrow()
    {
        if (_random.NextDouble() < 0.0001
        && !IsRipe)
        {
            IsRipe = true;
            Ripened?.Invoke(this, EventArgs.Empty);
        }

    }

    
}