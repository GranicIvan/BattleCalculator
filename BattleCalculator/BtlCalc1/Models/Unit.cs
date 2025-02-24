using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtlCalc1.Models
{
    internal class Unit
    {

        public string Name {  get; set; }
        public double Hp { get; set; } // health points
        public double Attack { get; set; } // attack 
        public double Armor { get; set; }
        public double AttackSpeed { get; set; } // attacks per second

        public Unit(string name, double hp, double atk, double armor, double attackSpeed)
        {
            this.Name = name;
            this.Hp = hp;
            this.Attack = atk;
            this.Armor = armor;
            this.AttackSpeed = attackSpeed;
        }

        public Unit(string name, double hp, double atk, double attackSpeed)
        {
            this.Name = name;
            this.Hp = hp;
            this.Attack = atk;            
            this.AttackSpeed = attackSpeed;
        }

        public bool isAlive()
        {
            return Hp > 0;
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
