using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Idf_operation
{
    internal class AttackManager
    {
        public List<Terrorist>_terrorists;
        public List<IAttackOptions> _attack;

        public AttackManager(List<Terrorist> terrorists, List<IAttackOptions>atack)
        {
            _terrorists = terrorists;
            _attack = atack;
        }
        public void ExecuteAttacks()
        {
            Terrorist highestRiskTerrorist = null;
            int highestDangerLevel = 0;

            foreach (var t in _terrorists)
            {
                Console.WriteLine(t.ToString());
                if (t.DangerLevel > highestDangerLevel)
                {
                    highestDangerLevel = t.DangerLevel;
                    highestRiskTerrorist = t;
                }
            }
            IAttackOptions selectedAttack = null;
            foreach (var t in _attack)
            {
                if (t.TypeOfTarget.Contains(highestRiskTerrorist.Location))
                    {
                    selectedAttack = t;
                    selectedAttack.AmountOfAttacks -= 1;
                    selectedAttack.AmountOfFuel -= 5;
                    break;

                }
                Console.WriteLine($"Mission accomplished  {highestRiskTerrorist.Status = "is died"}  ");
                Console.ReadKey();
            }   }       
    }
}
