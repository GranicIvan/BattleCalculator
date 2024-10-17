using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtlCalc1.Models
{
    internal class Unit
    {

        private string name {  get; set; }
        private double hp; // health points
        private double atk; // attack 
        private double armor;
        private double attackSpeed; // attacks per second

        public Unit(string name, double hp, double atk, double armor, double attackSpeed)
        {
            this.name = name;
            this.hp = hp;
            this.atk = atk;
            this.armor = armor;
            this.attackSpeed = attackSpeed;
        }

        public bool isAlive()
        {
            return hp > 0;
        }



        /* KAKO odraditi napade
         
         public class Fight
    {
    public static void StartFight(Character c1, Character c2)
    {
        double c1NextAttackTime = 1.0 / c1.AttackSpeed;
        double c2NextAttackTime = 1.0 / c2.AttackSpeed;

        double currentTime = 0;

        while (c1.IsAlive() && c2.IsAlive())
        {
            if (c1NextAttackTime <= c2NextAttackTime)
            {
                // Process c1's attack
                currentTime = c1NextAttackTime;
                c1.Attack(c2);
                c1NextAttackTime += 1.0 / c1.AttackSpeed;  // Schedule the next attack for c1
            }
            else
            {
                // Process c2's attack
                currentTime = c2NextAttackTime;
                c2.Attack(c1);
                c2NextAttackTime += 1.0 / c2.AttackSpeed;  // Schedule the next attack for c2
            }
        }

        Console.WriteLine(c1.IsAlive() ? $"{c1.Name} wins!" : $"{c2.Name} wins!");
    }
    }

         */

    }
}
