using System;
using System.Threading;

namespace Level_15_1;

public class SimulasTest
{
    public static void Main()
    {
        bool isLocked = true;

        Chest Current = Chest.Closed;

        /*WHILE LOOP*/
        int i; i = 1;
        while (i > 0)
        {
            Console.WriteLine("THE CHEST OPENER\n\n");

            Console.WriteLine("You found a locked chest with a strange Key laying next to it!");
            Console.WriteLine("You can Lock, Unlock, Open, and Close it.\n");
            Console.Write("What do you do? ");

            /* Input */
            Acts input = Enum.Parse<Acts>(Console.ReadLine());
            Console.Write("\n");

            /* MECHANISM */
            // Lock
            if (input == Acts.Lock)
            {
                if (isLocked && Current == Chest.Closed)
                {
                    Console.WriteLine("It is already locked!");
                }
                else if (isLocked && Current == Chest.Opened)
                {
                    Console.WriteLine("You locked it already..while being open..");
                }
                else if (!isLocked && Current == Chest.Closed)
                {
                    isLocked = true;
                    Console.WriteLine("You locked it!");
                }
                else if (!isLocked && Current == Chest.Opened)
                {
                    isLocked = true;
                    Console.WriteLine("You locked it..but why when it's still open?");
                }

            }
            // Unlock
            else if (input == Acts.Unlock)
            {
                if (isLocked && Current == Chest.Closed)
                {
                    isLocked = false;
                    Console.WriteLine("You unlocked the chest!");
                }
                else if (isLocked && Current == Chest.Opened)
                {
                    isLocked = false;
                    Console.WriteLine("You unlocked a new Steam Achievement.. as well as an open Chest! :D");
                }
                else if (!isLocked && Current == Chest.Closed)
                {
                    Console.WriteLine("It is already unlocked!");
                }
                else if (!isLocked && Current == Chest.Opened)
                {
                    Console.WriteLine("It is already unlocked");
                }
            }
            // Open
            else if (input == Acts.Open)
            {
                if (isLocked && Current == Chest.Closed)
                {
                    Console.WriteLine("First, you have to unlock it!");
                }
                else if (isLocked && Current == Chest.Opened)
                {
                    Console.WriteLine("It is already open!");
                }
                else if (!isLocked && Current == Chest.Closed)
                {
                    Current = Chest.Opened;
                    Console.WriteLine("You opened the chest!");
                }
                else if (!isLocked && Current == Chest.Opened)
                {
                    Console.WriteLine("It is already open!");
                }
            }
            // Close
            else if (input == Acts.Close)
            {
                if (isLocked && Current == Chest.Closed)
                {
                    Console.WriteLine("It is already closed!");
                }
                else if (isLocked && Current == Chest.Opened)
                {
                    Console.WriteLine("It's blocking! First You have to unlock it!");
                }
                else if (!isLocked && Current == Chest.Closed)
                {
                    Console.WriteLine("It is already closed!");
                }
                else if (!isLocked && Current == Chest.Opened)
                {
                    Current = Chest.Closed;
                    Console.WriteLine("You closed the chest!");
                }
                // Bad Input
                else
                {
                    Console.WriteLine("Bad Input");
                }
            }

            /*FINAL CONDITION*/
            //string Locked?
            string Locked = isLocked ? "Locked" : "Unlocked";

            Console.WriteLine($"This Chest is {Locked} and {Current}.");

            Thread.Sleep(5000);
            Console.Clear();
            i++;
        }
    }
}

enum Chest
{
    Opened,
    Closed
}

enum Acts
{
    Lock,
    Unlock,
    Open,
    Close
}