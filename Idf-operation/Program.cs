using System;
using System.Collections.Generic;

namespace Idf_operation
{
    class Program
    {
        static void Main(string[] args)
        {
            // שלב 1: יצירת רשימה של טרוריסטים
            List<Terrorist> terrorists = new List<Terrorist>
            {
                new Terrorist(),
                new Terrorist(),
                new Terrorist()
            };

            // שלב 2: חישוב סיכון
            intelligence intel = new intelligence(terrorists);
            intel.RiskAssessment();

            // שלב 3: יצירת רשימה של אפשרויות תקיפה
            List<IAttackOptions> attackOptions = new List<IAttackOptions>
            {
                new F16(),
                new Zik(),
                new Artillery()
            };

            // שלב 4: יצירת AttackManager והפעלת תקיפה
            AttackManager attackManager = new AttackManager(terrorists, attackOptions);
            attackManager.ExecuteAttacks();
       

            // הדפסת מצב אפשרויות התקיפה אחרי ההתקפה
            foreach (var a in attackOptions)
            {
                Console.WriteLine($"{a.AttackName}: {a.AmountOfAttacks} attacks remaining, {a.AmountOfFuel} fuel remaining");
                Console.ReadKey();
            }
        }
    }
}
