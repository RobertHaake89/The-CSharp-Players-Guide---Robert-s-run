using System;
using System.Diagnostics.Contracts;
using Microsoft.VisualBasic;

namespace Armored;

class Puppet
{
    public int HP {get; private set;} = 20;
    public Armor? Armor {get; set;}

    public int DealDamage(int netDamage)
    {
        HP -= netDamage;
        if (HP < 0) HP = 0;
        return netDamage;
    }
}

class Armor
{
    public int Durability {get; private set;} = 5;

    public int ReduceDamage(int grossDamage, out int netDamage)
    {
        if (grossDamage > 0 && Durability > 0)
        {
            netDamage = (int)MathF.Round(grossDamage * 0.5f);
            Durability--;
            return netDamage;
        }
        else
        {
            netDamage = grossDamage;
        }
        if (Durability < 0) Durability = 0;
        return netDamage;
    }
}