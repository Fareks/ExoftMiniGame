using SuperPower;
using Warriors;
using Battles;
SuperPowerGenerator superPowerGenerator = new SuperPowerGenerator();
SuperArmor superArmor = new SuperArmor();
Warrior archer = new Archer();
//archer.AddSuperPower(superArmor, superPowerGenerator.getSuperPower());
Battle.StartBattle(archer, archer);
