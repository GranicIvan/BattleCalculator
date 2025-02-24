using BtlCalc1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtlCalc1.ViewModels
{
    class Battle1v1VM //: INotifyPropertyChanged
    {

        public static Unit Battle1v1(Unit p1, Unit p2)
        {
            double p1NextAttackTime = 1.0 / p1.AttackSpeed;
            double p2NextAttackTime = 1.0 / p2.AttackSpeed;
            double currentTime = 0;
            while (p1.isAlive() && p2.isAlive())
            {
                if (p1NextAttackTime <= p2NextAttackTime)
                {
                    // Process p1's attack
                    currentTime += p1NextAttackTime;
                    p1.DealSimpleDamage(p2);
                    p1NextAttackTime = 1.0 / p1.AttackSpeed;  // Schedule the next attack for p1
                    p2NextAttackTime -= p1NextAttackTime; // Reduce the time for p2's next attack
                }
                else
                {
                    // Process p2's attack
                    currentTime += p2NextAttackTime;
                    p2.DealSimpleDamage(p1);
                    p2NextAttackTime = 1.0 / p2.AttackSpeed;  // Schedule the next attack for p2
                    p1NextAttackTime -= p2NextAttackTime; 
                }
            }

            if(p1.isAlive())
            {
                Trace.WriteLine(p1.Name + " wins!");
                return p1;
            }
            else
            {
                Trace.WriteLine(p2.Name + " wins!");
                return p2;
            }
        }

        


    }

    internal static class UnitExtensions
    {
        public static void DealSimpleDamage(this Unit p1, Unit p2)
        {
            double damage = p1.Attack;
            p2.Hp -= damage;
            Trace.WriteLine(p1.Name + " deals " + damage + " damage to " + p2.Name + ". " + p2.Name + " has " + p2.Hp + " HP left.");
        }
    }
}
