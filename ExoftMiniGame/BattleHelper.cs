using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warriors;
namespace BattleHelpers
{
    public static class BattleHelper
    {
        public static Warrior GenerateHero(string question)
        {
            Warrior hero;
            do
            {
                Console.WriteLine(question);
                var response = Console.ReadLine();
                hero = GetHero(response);
                if (hero == null)
                {
                    Console.WriteLine("Try again");
                }
            }
            while (hero == null);
            return hero;
        }

        public static Warrior GetHero(string input)
        {
            if (int.TryParse(input, out int result))
            {
                return result switch
                {
                    1 => new Archer(),
                    2 => new Swordman(),
                    3 => new Paladin(),
                    4 => new Mage(),
                    5 => new Archer()+ new Mage(),
                    _ => null,
                };
            }
            return null;
        }
    }
    public static class MyExt
    {
        public static void AddHP<T>(this T hero, int moreHP) where T : Warrior
        {
               hero.HP += moreHP;
        }
    }
}