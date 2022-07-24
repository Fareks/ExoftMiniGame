using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperPower;

namespace Warriors
{
    abstract class Warrior
    {
        protected int hp = 100;
        protected int armor;
        protected int attack;
        public int HP { get { return hp; } set { hp = value; } }
        public int Attack { get { return attack; } set { attack = value; } }
        public int Armor {get { return armor; }
        set { armor = value; }}

        public virtual void AddSuperPower( ISuperPower superPower, int x) 
        {
            superPower.AddSuperPower(this, x);
        }


            

        
    }

    internal class Archer : Warrior
    {
        public string name;
        public Archer()
        {
            attack = 12;
            armor = 8;
        }
        public override void AddSuperPower(ISuperPower superPower, int x)
        {
            superPower.AddSuperPower(this, x);
        }
    }

    internal class Swordman : Warrior
    {
        public Swordman()
        {
            armor = 10;
            attack = 10;
        }
        public override void AddSuperPower(ISuperPower superPower, int x)
        {
            superPower.AddSuperPower(this, x);
        }
    }

    internal class Paladin : Warrior
    {
        public Paladin()
        {
            armor = 15;
            attack = 5;
        }
        public override void AddSuperPower(ISuperPower superPower, int x)
        {
            superPower.AddSuperPower(this, x);
        }
    }

    internal class Mage : Warrior
    {
        public Mage()
        {
            armor = 5;
            attack = 15;
        }
        public override void AddSuperPower(ISuperPower superPower, int x)
        {
            superPower.AddSuperPower(this, x);
        }
    }
}
