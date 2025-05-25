using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idf_operation
{
    internal class intelligence
    {
        public int Score { get; set; }

        public int QualityScore {  get; set; }
        public List<Terrorist> Terorist1 { get; set; }

        private List<string> leastLocation = new List<string> { "home", "car", "outside" };

        public List<Terrorist> _terrorists;

        public intelligence(List<Terrorist> terrorists)
        {
            Terorist1 = terrorists;
        }
        public void ExecuteAttacks()
        {
            foreach (var terorist in _terrorists)
            {
                if (terorist.getwepon() == "GUN")
                {
                    Score += 2;
                }
                else if (terorist.getwepon() == "AKM")
                {
                    Score += 3;
                }
                else if (terorist.getwepon() == "knife")
                {
                    Score += 1;
                }
                QualityScore = Score * terorist.getrank();

            }
            
        }
    }
}
