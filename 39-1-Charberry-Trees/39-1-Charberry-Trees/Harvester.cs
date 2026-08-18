using System;
using System.Threading;

namespace CharberryTrees;

class Harvester
{
    public CharberryTree Tree {get; init;}

    public bool IsHarvested {get; set;}
    public event EventHandler? Harvested;

    public Harvester(CharberryTree tree)
    {
        Tree = tree;
    }

    public void TryHarvest(object? sender, EventArgs e)
    {
        if (Tree.IsRipe)
        {
            Thread.Sleep(4000);
            Tree.IsRipe = false;
        }
        else return;
        Harvested?.Invoke(this, EventArgs.Empty);
    }
}