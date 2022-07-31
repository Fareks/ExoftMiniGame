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

        public static void HeroesMenu()
        {
            List<Warrior> heroes = new List<Warrior>();
            Console.WriteLine("Please, choose num pairs of fighters (example: 2 pairs = 4 fighters)");
            int num =  int.Parse(Console.ReadLine());
            for (int i=0; i<num; i++)
            {
                heroes.Add(BattleHelper.GenerateHero("Player 1, choose your hero: 1. Archer, 2. Swordman, 3. Paladin, 4. Mage, 5. Morphling"));
            }
            //Warrior player_1 = BattleHelper.GenerateHero("Player 1, choose your hero: 1. Archer, 2. Swordman, 3. Paladin, 4. Mage, 5. Morphling");
            //Warrior player_2 = BattleHelper.GenerateHero("Player 2, choose your hero: 1. Archer, 2. Swordman, 3. Paladin, 4. Mage, 5. Morphling");
            //Warrior player_3 = BattleHelper.GenerateHero("Player 3, choose your hero: 1. Archer, 2. Swordman, 3. Paladin, 4. Mage, 5. Morphling");
            //Warrior player_4 = BattleHelper.GenerateHero("Player 4, choose your hero: 1. Archer, 2. Swordman, 3. Paladin, 4. Mage, 5. Morphling");
        }
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