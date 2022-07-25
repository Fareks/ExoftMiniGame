using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warriors;
using SuperPower;

namespace Battles
{
    public static class Battle
    {
        
        public static void StartBattle(Warrior player1, Warrior player2)
        {
            int round = 1;
            int[] current_damage = new int[2];

            while (player1.isAlive() && player2.isAlive())
            {

                Console.WriteLine($"Round {round}. Fight!");
                    Console.WriteLine("______________________");
                    player2.Defence(player1.Damage());
                    Console.WriteLine($"Player 1 attacks and deals -{player1.Attack} damage!");

                    player1.Defence(player2.Damage());
                    Console.WriteLine($"Player 2 attacks and deals -{player2.Attack} damage!");

                    Console.WriteLine($"Player 1: HP: {player1.HP}, Armor: {player1.Armor}");
                    Console.WriteLine($"Player 2: HP: {player2.HP}, Armor: {player2.Armor}");
                    Console.WriteLine($"Round finished! ");
                    round++;
                if(!player1.isAlive())
                {
                    Console.WriteLine("PLayer 2 win!");
                    break;
                } else
                if (!player2.isAlive())
                {
                    Console.WriteLine("PLayer 1 win!");
                    break;
                }
            }
    }

        
    }
}
