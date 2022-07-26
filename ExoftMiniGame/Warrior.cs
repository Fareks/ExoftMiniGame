﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperPower;

namespace Warriors
{
    public abstract class Warrior
    {
        protected int hp = 100;
        protected int armor;
        protected int attack;
        public string name;

        public int HP { get { return hp; } set { hp = value; } }
        public int Attack { get { return attack; } set { attack = value; } }
        public int Armor {get { return armor; }
        set { armor = value; }}

        public virtual void AddSuperPower( ISuperPower superPower, int x) 
        {
            superPower.AddSuperPower(this, x);
        }

        public bool isAlive()
        {
            if (hp > 0)
            {
                return true;
            }
            else { return false; }
        }

        public void Defence(int enemy_damage)
        {
            if (armor > 0) //якщо є армор
            {
                if (enemy_damage > 1)//а шкода > 1
                {   
                    if ((enemy_damage/2) >= armor)
                    //якщо дамагу більше, аніж може впитати броня 
                    {
                        hp -= enemy_damage - armor;
                        armor = 0;
                    } else
                    {
                        armor -= enemy_damage / 2;
                        hp -= enemy_damage - (enemy_damage / 2); //враховуємо 
                                                                 //залишок від ділення чілочисельного int
                    }

                }
                else if (enemy_damage == 1)
                {
                    armor -= enemy_damage;
                }
            } else { 
                hp -= enemy_damage;                   
            }
        }

        public int Damage()
        {
            if (armor > 0)
            {
                return attack;
            } else
            {
                if (attack > 1)
                {
                    attack--;
                }
                return attack;
                
            }
        }
    }

    internal class Archer : Warrior
    {
       
        public Archer()
        {
            attack = 12;
            armor = 8;
            name = "Archer";
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
            name = "Swordman";
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
            name = "Paladin";
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
            name = "Mage";
        }
        public override void AddSuperPower(ISuperPower superPower, int x)
        {
            superPower.AddSuperPower(this, x);
        }
    }
}
