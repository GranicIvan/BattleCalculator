using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtlCalc1.Models
{
    class BattleResult1v1
    {
        public Unit Winner { get; set; }
        public Unit Loser { get; set; }
        public double BattleTime { get; set; }



        public BattleResult1v1(Unit p1, Unit p2, double time) 
        {
            if(p1.isAlive())
            {
                Winner = p1;
                Loser = p2;
            }
            else
            {
                Winner = p2;
                Loser = p1;
            }

            
            BattleTime = time;
        }

        public override string ToString()
        {
            return $"{Winner.Name} wins against {Loser.Name} in {BattleTime:F2} seconds. Winner has {Winner.HP:F2} hp left.";
        }

        public string PritntResult()
        {
            return $"{Winner.Name} wins against {Loser.Name} in {BattleTime:F2} seconds. Winner has {Winner.HP:F2} hp left.";
        }
    }

    
}
