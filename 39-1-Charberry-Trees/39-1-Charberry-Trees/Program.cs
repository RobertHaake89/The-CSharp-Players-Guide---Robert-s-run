using System;
using System.Threading;

namespace CharberryTrees;

class Program
{
    public static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("\n\t\tCharberry Trees\n\n");

        var tree = new CharberryTree();
        var notifier = new Notifier(tree);
        var harvester = new Harvester(tree);

        tree.Ripened += notifier.Tree_Ripened;
        tree.Ripened += harvester.TryHarvest;
        harvester.Harvested += notifier.Tree_Harvested;

        while (true)
        {
            tree.MaybeGrow();
            
            Thread.Sleep(1);
        }
    }
}