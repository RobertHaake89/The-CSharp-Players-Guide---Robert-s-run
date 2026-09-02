using System;

namespace TheRobotFactory;

class Garage
{
    public IDictionary<int, object> Collection {get; set;} = new Dictionary<int, object>();
}