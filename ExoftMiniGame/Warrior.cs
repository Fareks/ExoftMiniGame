using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperPower;

namespace Warriors
{
    public abstract class Warrior
    {
        
        public string name;

        public int HP { get; set; } = 100;
        public int Attack { get; set; } = 10;
        public int Armor { get; set; } = 10;
        public virtual void AddSuperPower( ISuperPower superPower, int x) 
        {
            superPower.AddSuperPower(this, x);
        }

        public bool isAlive()
        {
            if (HP > 0)
            {
                return true;
            }
            else { return false; }
        }

        public void Defense(int enemy_damage)
        {
            if (Armor > 0) //якщо є армор
            {
                if (enemy_damage > 1)//а шкода > 1
                {   
                    if ((enemy_damage/2) >= Armor)
                    //якщо дамагу більше, аніж може впитати броня 
                    {
                        HP -= enemy_damage - Armor;
                        Armor = 0;
                    } else
                    {

                        Armor -= enemy_damage / 2;
                        HP -= enemy_damage - (enemy_damage / 2); //враховуємо 
                                                                 //залишок від ділення чілочисельного int
                    }

                }
                else if (enemy_damage == 1)
                {
                    Armor -= enemy_damage;
                }
            } else { 
                HP -= enemy_damage;                   
            }
        }

        public int Damage()
        {
            if (Armor > 0)
            {
                return Attack;
            } else
            {
                if (Attack > 1)
                {
                    Attack--;
                }
                return Attack;
                
            }
        }

        public static Warrior operator +(Warrior warrior1, Warrior warrior2)
        {
            Random random = new Random();
            return new Morphling { HP = warrior1.HP + random.Next(-2, 2), Armor = warrior2.Armor + random.Next(-2, 2), Attack = warrior1.Attack + random.Next(-2, 2) };
        }
    }

    internal class Archer : Warrior
    {
       
        public Archer()
        {
            Attack = 12;
            Armor = 8;
            name = "Archer";
        }
    }

    internal class Swordman : Warrior
    {
        public Swordman()
        {
            Armor = 10;
            Attack = 10;
            name = "Swordman";
        }

    }

    internal class Paladin : Warrior
    {
        public Paladin()
        {
            Armor = 15;
            Attack = 5;
            name = "Paladin";
        }

    }

    internal class Mage : Warrior
    {
        public Mage()
        {
            Armor = 5;
            Attack = 15;
            name = "Mage";
        }
    }

    internal class Morphling : Warrior
    {
        
        public Morphling()
        {
            Armor = 10;
            Attack = 10;
            name = "Morphling";
        }
    }
}
