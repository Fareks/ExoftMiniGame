using SuperPower;
using Warriors;
using Battles;
SuperPowerGenerator superPowerGenerator = new SuperPowerGenerator();
SuperArmor superArmor = new SuperArmor();
Warrior player1 = new Archer();
Warrior player2 = new Archer();


Console.WriteLine("Player 1, choose your hero:");
Console.WriteLine("1: Archer, 2: Swordman, 3: Paladin, 4: Mage.");
string player_1 = Console.ReadLine().ToString();
Console.WriteLine("Player 2, choose your hero:");
Console.WriteLine("1: Archer, 2: Swordman, 3: Paladin, 4: Mage.");
string player_2 = Console.ReadLine().ToString();


switch (player_1)
{
    case "1":
        player1 = new Archer();
        break;
    case "2":
        player1 = new Swordman();
        break;
    case "3":
        player1 = new Paladin();
        break;
    case "4":
        player1 = new Mage();
        break;
}

switch (player_2)
{
    case "1":
        player2 = new Archer();
        break;
    case "2":
        player2 = new Swordman();
        break;
    case "3":
        player2 = new Paladin();
        break;
    case "4":
        player2 = new Mage();
        break;
}

player2.AddSuperPower(superArmor, superPowerGenerator.getSuperPower());
Console.WriteLine($" Prepare for battle! {player1.name} VS {player2.name}");
Battle.StartBattle(player1, player2);
