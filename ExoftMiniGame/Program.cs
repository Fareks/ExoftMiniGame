using SuperPower;
using Warriors;
using Battles;
using BattleHelpers;

SuperPowerGenerator superPowerGenerator = new SuperPowerGenerator();
SuperArmor superArmor = new SuperArmor();



player_3.AddSuperPower(superArmor, superPowerGenerator.getSuperPower());
player_1.AddSuperPower(superArmor, superPowerGenerator.getSuperPower());
player_1.AddHP(5);
Console.WriteLine($" Prepare for battle! {player_1.name} VS {player_2.name}");
var battleTask = new Task(async()=> await Battle.StartBattle(player_1, player_2,1000));
var battleTask2= new Task(async () => await Battle.StartBattle(player_3, player_4,500));
battleTask.Start();
battleTask2.Start();
Console.WriteLine($" Status 1 {battleTask} ____ Status 2 {battleTask2}" );
Console.ReadKey();
