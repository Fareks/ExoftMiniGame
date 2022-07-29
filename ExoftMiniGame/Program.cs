using SuperPower;
using Warriors;
using Battles;
using BattleHelpers;

SuperPowerGenerator superPowerGenerator = new SuperPowerGenerator();
SuperArmor superArmor = new SuperArmor();


Warrior player_1 = BattleHelper.GenerateHero("Player 1, choose your hero: 1. Archer, 2. Swordman, 3. Paladin, 4. Mage, 5. Morphling");
Warrior player_2 = BattleHelper.GenerateHero("Player 2, choose your hero: 1. Archer, 2. Swordman, 3. Paladin, 4. Mage, 5. Morphling");
Warrior player_3 = new Archer();
Warrior player_4 = new Paladin();
player_2.AddSuperPower(superArmor, superPowerGenerator.getSuperPower());
player_1.AddSuperPower(superArmor, superPowerGenerator.getSuperPower());
player_1.AddHP(5);
Console.WriteLine($" Prepare for battle! {player_1.name} VS {player_2.name}");
var battleTask = new Task(async()=> await Battle.StartBattle(player_1, player_2,1000));
var battleTask2= new Task(async () => await Battle.StartBattle(player_3, player_4,500));
battleTask.Start();
battleTask2.Start();
Console.WriteLine($" Status 1 {battleTask} ____ Status 2 {battleTask2}" );
Console.ReadKey();
