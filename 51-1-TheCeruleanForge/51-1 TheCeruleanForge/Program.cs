using System;
using System.IO;

namespace CeruleanForge;

public class Program
{
    public static void Main()
    {
        string[] scoreText = File.ReadAllLines("Checkerboard.sc")[1..];
        int matSizeInput = int.Parse(File.ReadAllLines("Checkerboard.sc")[0]);
 
        List<Strand> strands2 = new List<Strand>(); 
        Material material = new Material(matSizeInput);
        
        foreach (string text in scoreText) 
        { 
            string[] parts = text.Split(","); 
            Color color = new Color(byte.Parse(parts[0]), byte.Parse(parts[1]), byte.Parse(parts[2])); 
            Position position = new Position(int.Parse(parts[3]), int.Parse(parts[4]));
            Position offset = new Position(int.Parse(parts[5]), int.Parse(parts[6]));
            
            string instructions = parts[7]; 

            strands2.Add(new Strand(material, instructions, color, position, offset)); 
        } 


        CeruleanForge forge = new (material, strands2);


        // DEBUG
        /*foreach (Strand strand in strands)
        {
            Console.WriteLine(strand.Material.Size);
            Console.WriteLine($"{strand.Color.R} {strand.Color.G} {strand.Color.B}");
            Console.WriteLine($"{strand.Position.Row}, {strand.Position.Column}");
            Console.WriteLine($"{strand.Offset.Row}, {strand.Offset.Column}");
            Console.WriteLine($"{strand.Instructions}\n");

            //Console.WriteLine(Position.Wrap(strand.Position, strand.Material.Size));
            //Console.WriteLine($"{strand.Position.Row}  {strand.Position.Column}");
        }
        Console.ReadKey();*/

        forge.Run();
    }
}


