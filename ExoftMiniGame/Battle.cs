﻿using System;
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
        
        public static async Task StartBattle(Warrior player1, Warrior player2,int delay)
        {

            int roundCount = 1;
            int[] current_damage = new int[2];
            Console.WriteLine($"Battle started! {player1.name} vs {player2.name}");
                do
                {
                Console.WriteLine($"Round {++roundCount}");
                    player2.Defense(player1.Damage());
                    player1.Defense(player2.Damage());
                    Console.WriteLine($"{player1.name}: HP: {player1.HP}, Armor: {player1.Armor}");
                    Console.WriteLine($"{player2.name}: HP: {player2.HP}, Armor: {player2.Armor}");
                    Console.WriteLine($"Round finished! ");
                await Task.Delay(delay);
                } while (player1.isAlive() && player2.isAlive());

                var winner = player1.isAlive()
                    ? player1
                    : player2.isAlive()
                        ? player2
                        : null;

                var looser = winner != player1
                    ? player1
                    : player2;

                if (winner != null)
                {
                    Console.WriteLine($"{winner} won in {roundCount} round.\n HP left {winner.HP}.\n Looser is {looser}.");
                }
                else
                {
                    Console.WriteLine("No winners");
                }
    }

        
    }
}
