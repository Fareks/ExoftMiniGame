using SuperPower;
using Warriors;
using BattleHelpers;
using Battles;

public class Program
{
    public static async Task Main()
    {
        int input = 1;
        do
        {
            SuperPowerGenerator superPowerGenerator = new SuperPowerGenerator();
            SuperArmor superArmor = new SuperArmor();
            var heroes = BattleHelper.GetHeroesList();

            heroes[0].AddSuperPower(superArmor, superPowerGenerator.getSuperPower());
            heroes[1].AddSuperPower(superArmor, superPowerGenerator.getSuperPower());
            heroes[0].AddHP(5);

            var battleTasks = heroes
                .Chunk(2)
                .Select(x => Battle.StartBattle(x.First(), x.Last(), 100));
            await Task.WhenAll(battleTasks);
            Console.WriteLine("Start new battle? 1 - Yes;  2 or any - No");

            input = int.Parse(Console.ReadLine());

        } while (input == 1);

        Console.ReadKey();
    }
}

