using SuperPower;
using Warriors;
using Battles;
using BattleHelpers;

SuperPowerGenerator superPowerGenerator = new SuperPowerGenerator();
SuperArmor superArmor = new SuperArmor();


Warrior player_1 = BattleHelper.GenerateHero("Player 1, choose your hero: 1. Archer, 2. Swordman, 3. Paladin, 4. Mage, 5. Morphling");
Warrior player_2 = BattleHelper.GenerateHero("Player 2, choose your hero: 1. Archer, 2. Swordman, 3. Paladin, 4. Mage, 5. Morphling");

player_2.AddSuperPower(superArmor, superPowerGenerator.getSuperPower());
player_1.AddSuperPower(superArmor, superPowerGenerator.getSuperPower());
player_1.AddHP(5);
Console.WriteLine($" Prepare for battle! {player_1.name} VS {player_2.name}");
Battle.StartBattle(player_1, player_2);

