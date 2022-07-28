using SuperPower;
using Warriors;
using Battles;
using BattleHelpers;

SuperPowerGenerator superPowerGenerator = new SuperPowerGenerator();
SuperArmor superArmor = new SuperArmor();


Warrior player_1 = BattleHelper.GenerateHero("Гравець 1, оберіть вашого героя: 1. Лучник, 2. Мечник, 3. Паладін, 4. Маг");

string player_2 = Console.ReadLine().ToString();



player2.AddSuperPower(superArmor, superPowerGenerator.getSuperPower());
Console.WriteLine($" Prepare for battle! {player1.name} VS {player2.name}");
Battle.StartBattle(player1, player2);
