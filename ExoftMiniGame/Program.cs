using SuperPower;
using Warriors;
using Battles;
using BattleHelpers;

SuperPowerGenerator superPowerGenerator = new SuperPowerGenerator();
SuperArmor superArmor = new SuperArmor();


List<Warrior> heroes = BattleHelper.GetHeroesList();

heroes[0].AddSuperPower(superArmor, superPowerGenerator.getSuperPower());
heroes[1].AddSuperPower(superArmor, superPowerGenerator.getSuperPower());
heroes[0].AddHP(5);

BattleHelper.StartAllBattles(heroes);



//ЗАПИТАТИСЬ ПРО ПРАВИЛЬНИЙ ЗАПУСК ТАСКІВ В ЛІСТІ

//foreach (Task task in allBattles)
//{
//    task.Start();
//}

//Parallel.ForEach(allBattles, task =>
//{
//    task.Start();
//    Console.WriteLine("Task started!");
//});

Console.ReadKey();
