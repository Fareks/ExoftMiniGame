using SuperPower;
using Warriors;
using BattleHelpers;
public class Program
{
    public static async Task Main()
    {
        int input = 1;
        do
        {
            SuperPowerGenerator superPowerGenerator = new SuperPowerGenerator();
            SuperArmor superArmor = new SuperArmor();
            List<Warrior> heroes = BattleHelper.GetHeroesList();

            heroes[0].AddSuperPower(superArmor, superPowerGenerator.getSuperPower());
            heroes[1].AddSuperPower(superArmor, superPowerGenerator.getSuperPower());
            heroes[0].AddHP(5);

            await Task.WhenAll(BattleHelper.GetAllBattles(heroes));

            Console.WriteLine("Start new battle? 1 - Yes;  2 or any - No");

            input = int.Parse(Console.ReadLine());

        } while (input == 1);

        Console.ReadKey();
    }
}

