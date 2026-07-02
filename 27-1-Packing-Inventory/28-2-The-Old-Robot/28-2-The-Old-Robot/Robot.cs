using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace TheOldRobot;

public class Robot
{
    public int X {get; set;} = 0;
    public int Y {get; set;} = 0;
    public bool IsPowered {get; set;} = false;
    public RobotCommand?[] Commands {get; } = new RobotCommand?[3];

    public void Run()
    {
        foreach (RobotCommand? command in Commands)
        {
            command?.Run(this);
            Console.WriteLine($"[{X} {Y} {IsPowered}]");
        }
    }
}

public abstract class RobotCommand
{
    public virtual void Run(Robot robot)
    {
        
    }
}
// ###########################################
public class OnCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        robot.IsPowered = true;
    }
}

public class OffCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        robot.IsPowered = false;
    }
}

// ###########################################

public class NorthCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (!robot.IsPowered)
        {
            Console.WriteLine("Robot isn't turned on!");
            return;
        }

        robot.Y++;
    }
}
public class EastCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (!robot.IsPowered)
        {
            Console.WriteLine("Robot isn't turned on!");
            return;
        }

        robot.X++;
    }
}
public class SouthCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (!robot.IsPowered)
        {
            Console.WriteLine("Robot isn't turned on!");
            return;
        }

        robot.Y--;
    }
}
public class WestCommand : RobotCommand
{
    public override void Run(Robot robot)
    {
        if (!robot.IsPowered)
        {
            Console.WriteLine("Robot isn't turned on!");
            return;
        }

        robot.X--;
    }
}