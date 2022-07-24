using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warrior
{
    abstract class Warrior
    {
        protected int hp = 100;
        protected int armor;
        protected int attack;

        void setAttribute(int armor,int attack)
        {
            this.armor = armor;
            this.attack = attack;
        }
        public int getAttack ()
        {
            return armor;
        }

    }

    internal class Archer : Warrior
    {
        int armor = 8;
        int attack = 12;
    }

    internal class Swordman : Warrior
    {
        int armor = 10;
        int attack = 10;
    }

    internal class Paladin : Warrior
    {
        int armor = 15;
        int attack = 5;
    }

    internal class Mage : Warrior
    {
        int armor = 5;
        int attack = 15;
    }
}
