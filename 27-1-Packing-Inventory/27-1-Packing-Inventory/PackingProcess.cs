using System;
using System.Collections;
using System.Collections.Generic;

namespace PackingInventory;

class PackingProcess
{
    public static void GeneralLoop(Pack pack)
    {
        
        bool running = true;
        while (running)
        {
            pack.MainMenu();
            int choiceMain = Convert.ToInt32(Console.ReadLine());

            switch(choiceMain)
            {
            case 1:
                pack.Add();
                break;

            case 2:
                pack.Remove();
                break;

            case 3:
                return;

            default:
            Console.WriteLine("Bad Input");
            break;
            }
            

            //Console.ReadKey();

            
            


            //running = false;
            
        }
        Console.ResetColor();
    }
}  
