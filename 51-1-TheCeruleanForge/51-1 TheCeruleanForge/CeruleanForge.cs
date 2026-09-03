using System;

namespace CeruleanForge;

// Represents the entire forge, which uses a set of strands to weave a material.
public class CeruleanForge(Material material, Strand[] strands)
{
    // The material being woven.
    public Material Material { get; } = material;

    // The set of strands doing the weaving.
    public Strand[] Strands { get; } = strands;

    // Runs the strands to weave the material. This runs indefinitely.
    public void Run()
    {
        // Puts the console window into a good initial state.
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Clear();
        Console.CursorVisible = false;

        // Before we get started, make a renderer to show our progress.
        Renderer renderer = new Renderer(Material);
        while (true)
        {
            // Run one instruction for each strand.
            foreach (Strand strand in Strands)
                strand.RunNextInstruction();

            // Stop and wait briefly, to create an illusion that it takes a bit 
            // of time to weave materials. This is purely for storytelling 
            // purposes, and you can remove it at your discretion. (But note that
            // the initial flavor of rendering just takes some time and will 
            // still run a bit slow. That will be fixed in one of the                  
            // challenges.)
            Thread.Sleep(10);
            renderer.Render();
        }
    }
}