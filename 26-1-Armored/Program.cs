using System;

namespace Armored;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\t\t\tARMORED\n\n");

        var puppet = new Puppet();
        var armor = new Armor();
        puppet.Armor = armor;
        
        int grossDamage = 5;
        int netDamage;
        puppet.Armor.ReduceDamage(grossDamage, out netDamage);
        puppet.InputDamage(netDamage);

        Console.WriteLine($"You dealt {netDamage} damage! Puppet has {puppet.HP} HP left and {puppet.Armor.Durability} Armor!");
    }
}