using System;

namespace CeruleanForge;

public class Program
{
    public static void Main()
    {
        //File.ReadAllLines("obj/Checkerboard.cs", scoreText);

        string[] scoreText = File.ReadAllLines("obj/Checkerboard.cs"); 
 
        List<Strand> input = new(); 
        
        foreach (string text in scoreText) 
        { 
            string[] parts = text.Split(","); 
            Material size = new Material(int.Parse(parts[0])); 
            Color color = new Color(byte.Parse(parts[1]), byte.Parse(parts[2]), byte.Parse(parts[3])); 
            Position position = new Position(int.Parse(parts[4]), int.Parse(parts[5]));
            Position offset = new Position(int.Parse(parts[6]), int.Parse(parts[7]));
            
            string instructions = parts[8]; 

            input.Add(new Strand(size, instructions, color, position, offset)); 
        }

        

        Material material = new Material(85);
        Strand[] strands =
        [
            new Strand(material, "*^*^*^*<<*<*<*<*vv*v*v*v*>>*>*>*>*>>>>>>>>>^^^^", Colors.Cerulean, new Position(1, 3), new Position(0, 0)),
            new Strand(material, "*^*^*^*^*^*^*^*<<^^", Colors.Azure/*White*/, new Position(3, 5), new Position(0, 0)),
            new Strand(material, "*>*v*<*^>>>>>>>>>^^", Colors.White/*Turquoise*/, new Position(0, 0), new Position(0, 0)),
            new Strand(material, "*>*>*>*>*>*>*>*^^>>", Colors.Azure, new Position(3, 7), new Position(0, 0)),
        ];

        CeruleanForge forge = new (material, strands);


        // DEBUG
        /*Console.WriteLine(strands[0].Material.Size);
        Console.WriteLine($"{strands[0].Position.Row}  {strands[0].Position.Column}");

        Console.WriteLine(Position.Wrap(strands[0].Position, strands[0].Material.Size));
        Console.WriteLine($"{strands[0].Position.Row}  {strands[0].Position.Column}");*/

        //Console.ReadKey();

        forge.Run();
    }
}


