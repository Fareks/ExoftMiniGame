using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warriors;

namespace SuperPower
{   
    internal class SuperHealth : ISuperPower
    {   
        public void AddSuperPower(Warrior warrior, int power)
        {
            warrior.HP += power;
        }
    }
    internal class SuperArmor : ISuperPower
    {
        public void AddSuperPower(Warrior warrior, int power)
        {
            warrior.Armor += power;
        }
    }
    internal class SuperAttack : ISuperPower
    {
        public void AddSuperPower(Warrior warrior, int power)
        {
            warrior.Attack += power;
        }
    }
}

