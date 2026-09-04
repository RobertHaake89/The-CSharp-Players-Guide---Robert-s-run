using System;

namespace CeruleanForge;


public class Program
{
    public static void Main()
    {
        Material material = new Material(25);
        Strand[] strands =
        [
            new Strand(material, "*^*^*^*<<*<*<*<*vv*v*v*v*>>*>*>*>*>>>>>>>>>^^^^", Colors.Cerulean, new Position(1, 3), new Position(0, 0)),
            new Strand(material, "*^*^*^*^*^*^*^*<<^^", Colors.White, new Position(3, 5), new Position(0, 0)),
            new Strand(material, "*>*v*<*^>>>>>>>>>^^", Colors.Turquoise, new Position(0, 0), new Position(0, 0)),
            new Strand(material, "*>*>*>*>*>*>*>*^^>>", Colors.LavenderBlush, new Position(3, 7), new Position(0, 0)),
        ];

        CeruleanForge forge = new (material, strands);

        /*Console.WriteLine(strands[0].Material.Size);
        Console.WriteLine($"{strands[0].Position.Row}  {strands[0].Position.Column}");

        Console.WriteLine(Position.Wrap(strands[0].Position, strands[0].Material.Size));
        Console.WriteLine($"{strands[0].Position.Row}  {strands[0].Position.Column}");*/

        //Console.ReadKey();

        forge.Run();
    }
}


