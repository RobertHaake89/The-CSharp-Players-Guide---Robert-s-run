using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace TheOldRobot;

public class Robot
{
    public int X {get; set;} = 0;
    public int Y {get; set;} = 0;
    public bool IsPowered {get; set;} = false;
    public IRobotCommand?[] Commands {get; } = new IRobotCommand?[3];

    public void Run()
    {
        foreach (IRobotCommand? command in Commands)
        {
            command?.Run(this);
            Console.WriteLine($"[{X} {Y} {IsPowered}]");
        }
    }
}

public interface IRobotCommand
{
     void Run(Robot robot)
    {
        
    }
}
// ###########################################
public class OnCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        robot.IsPowered = true;
    }
}

public class OffCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        robot.IsPowered = false;
    }
}

// ###########################################

public class NorthCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (!robot.IsPowered)
        {
            Console.WriteLine("Robot isn't turned on!");
            return;
        }

        robot.Y++;
    }
}
public class EastCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (!robot.IsPowered)
        {
            Console.WriteLine("Robot isn't turned on!");
            return;
        }

        robot.X++;
    }
}
public class SouthCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (!robot.IsPowered)
        {
            Console.WriteLine("Robot isn't turned on!");
            return;
        }

        robot.Y--;
    }
}
public class WestCommand : IRobotCommand
{
    public void Run(Robot robot)
    {
        if (!robot.IsPowered)
        {
            Console.WriteLine("Robot isn't turned on!");
            return;
        }

        robot.X--;
    }
}