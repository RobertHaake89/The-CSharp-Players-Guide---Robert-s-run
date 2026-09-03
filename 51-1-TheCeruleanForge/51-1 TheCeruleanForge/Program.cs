using System;

namespace CeruleanForge;


public class Program
{
    public static void Main()
    {
        Material material = new Material(85);
        Strand[] strands =
        [
            new Strand(material, "*^*^*^*<<*<*<*<*vv*v*v*v*>>*>*>*>*>>>>>>>>>^^^^", Colors.White, new Position(1, 3), new Position(0, 0)),
            new Strand(material, "*^*^*^*^*^*^*^*<<^^", Colors.White, new Position(3, 5), new Position(0, 0)),
            new Strand(material, "*>*v*<*^>>>>>>>>>^^", Colors.White, new Position(0, 0), new Position(0, 0)),
            new Strand(material, "*>*>*>*>*>*>*>*^^>>", Colors.White, new Position(3, 7), new Position(0, 0)),
        ];

        CeruleanForge forge = new (material, strands);
        forge.Run();
    }
}


