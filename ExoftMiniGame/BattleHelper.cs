using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warriors;
using Battles;
namespace BattleHelpers
{
    public static class BattleHelper
    {
        public static List<Task> StartAllBattles (List<Warrior> AllHeroes)
        {
            var battles = new List<Task>();
            
            for (int x = 0; x < AllHeroes.Count; x += 2)
            {
                var w1 = AllHeroes[x];
                var w2 = AllHeroes[x + 1];

                var index = x;

                battles.Add(new Task(() =>
                {
                    Battle.StartBattle(w1, w2, 100);

                }));
                Console.WriteLine($"Task created. Heroes: {AllHeroes[x].name} vs {AllHeroes[x + 1].name}");

                if( (x+2) > AllHeroes.Count-1)
                {
                    break;
                }
            }
            return battles;
        }
        public static List<Warrior> GetHeroesList()
        {
            List<Warrior> heroes = new List<Warrior>();
            int num = 0;
            do
            {
                Console.WriteLine("Please, choose num pairs of fighters (example: 2 pairs = 4 fighters). Max: 100");
                num = int.Parse(Console.ReadLine());
                if (num < 1 || num > 101)
                {
                    num = 0;
                    Console.WriteLine("Please, try again.");
                }
            }
            while (num == 0);


            for (int i=0; i<num; i++)
            {
                heroes.Add(BattleHelper.GenerateHero($"Hero {i+1}, choose your hero: 1. Archer, 2. Swordman, 3. Paladin, 4. Mage, 5. Morphling"));
                heroes.Add(BattleHelper.GenerateHero($"Hero {i + 2}, choose your hero: 1. Archer, 2. Swordman, 3. Paladin, 4. Mage, 5. Morphling"));
                Console.WriteLine($"{heroes[i]} vs {heroes[i+1]}");
            }
            return heroes;
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