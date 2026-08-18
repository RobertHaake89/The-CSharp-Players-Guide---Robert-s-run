using System;

namespace CharberryTrees;

public class Notifier
{
    public CharberryTree Tree {get; init;}

    public Notifier(CharberryTree tree)
    {
        Tree = tree;
    }

    public void Tree_Ripened(object? sender, EventArgs e)
    {
    Console.WriteLine("The tree has ripened!");
    }

    public void Tree_Harvested(object? sender, EventArgs e)
    {
    Console.WriteLine("The tree has been harvested!\n");
    }
}