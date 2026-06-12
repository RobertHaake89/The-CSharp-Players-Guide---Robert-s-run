using System;

namespace Armored;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\t\t\tARMORED\n\n");

        var puppet = new Puppet();
        var armor = new Armor(Armor.ArmorType.Leather);
        puppet.Armor = armor;
        
        for (int i = 0; i < 10; i++)
        {
            int grossDamage = 5;
            int netDamage;
            puppet.Armor.ReduceDamage(grossDamage, out netDamage);
            puppet.InputDamage(netDamage);

            Console.WriteLine($"You dealt {netDamage} damage! Puppet has {puppet.HP} HP left and {puppet.Armor.Condition} Armor!");
        }
    }
}