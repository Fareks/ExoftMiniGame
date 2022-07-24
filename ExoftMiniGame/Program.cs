using SuperPower;
using Warriors;

SuperPowerGenerator superPowerGenerator = new SuperPowerGenerator();
SuperArmor superArmor = new SuperArmor();
Warrior archer = new Archer();
archer.AddSuperPower(superArmor, superPowerGenerator.getSuperPower());

Console.WriteLine(archer.Armor);

