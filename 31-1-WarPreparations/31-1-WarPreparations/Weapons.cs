using System;
using System.Data;

namespace WarPreparations;

enum Material
{
    Wood = 1,
    Bronze,
    Iron,
    Steel,
    Binarium = 10
}
enum Gemstone
{
    None = 0,
    Emerald,
    Amber,
    Sapphire,
    Diamond,
    Bitstone = 10
}

record Sword(string _name, Material _material, Gemstone _gemstone, float _length, float _crossGuardWidth);


    

