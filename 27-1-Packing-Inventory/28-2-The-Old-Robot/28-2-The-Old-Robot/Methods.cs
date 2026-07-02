using System;

namespace TheOldRobot;

public class Methods
{
    public static RobotCommand GetCommand(int input)
    {
        switch (input)
        {
            case 1:
            return new OnCommand();
            case 2:
            return new SouthCommand();
            case 3:
            return new SouthCommand();
            case 4:
            return new WestCommand();
            case 6:
            return new EastCommand();
            case 8:
            return new NorthCommand();
            default:
            throw new Exception("Bad Input");

        }
    }
}