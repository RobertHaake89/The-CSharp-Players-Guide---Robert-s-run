using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using Microsoft.VisualBasic;

namespace Armored;

class Puppet
{
    public int HP {get; private set;} = 20;
    public Armor? Armor {get; set;}

    public int InputDamage(int netDamage)
    {
        HP -= netDamage;
        if (HP < 0) HP = 0;
        return netDamage;
    }
}

public class Armor
{
    public enum ArmorType
    {
        Leather = 1, // 25% protection
        Iron, // 50%
        DragonScale // 80%
    }
    
    public ArmorType Type {get; private set;}
    public float DefenceValue {get; private set;}
    public int Condition {get; set;} = 5; //Random.Shared.Next(1,101);

    public Armor(ArmorType type)
    {
        Type = type;
        DefenceValue = GetTypeDefenceValue();
    }

    public float GetTypeDefenceValue() => Type switch
    {
        ArmorType.Leather => 0.25f,
        ArmorType.Iron => 0.5f,
        ArmorType.DragonScale => 0.8f,
        _ => throw new ArgumentException("Invalid armor type")
    };

    public int ReduceDamage(int grossDamage, out int netDamage)
    {
        
        if (grossDamage > 0 && Condition > 0)
        {
            netDamage = (int)MathF.Round(grossDamage - (grossDamage * DefenceValue)); // inverted damagemultiplier to damagereduction -> best would be damage * (1 - DefenceValue)
            Condition--;
            
            return netDamage;
        }
        if (Condition < 0) Condition = 0;
          
        netDamage = grossDamage;
        return netDamage;
    }
}