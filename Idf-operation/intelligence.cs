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

        private List<string> leastLocation = new List<string> { "home", "car", "outside" };

        public List<Terrorist> Terrorists { get; set; }

        public intelligence(List<Terrorist> terrorists)
        {
            Terrorists = terrorists;
        }
        public void RiskAssessment()
        {
            foreach (var terorist in Terrorists)

            {
                if (terorist.Weapons.Contains("GUN"))
                {
                    Score += 2;
                }
                else if (terorist.Weapons.Contains ("AKM"))
                {
                    Score += 3;
                }
                else if (terorist.Weapons.Contains( "knife"))
                {
                    Score += 1;
                }
                QualityScore = Score * terorist.Rank;
                terorist.DangerLevel = QualityScore;
            }
            

        }
    }
}
