using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Idf_operation
{
    internal class Terrorist
    {

        public string Name { get; set; }
        public int Rank { get; set; }
        public string Status { get; set; }
        public List<string> Weapons { get; private set; }
        public string Location { get; set; }
       
        public int DangerLevel = 0;



        public Terrorist()
        {
            Name = _namePool[_random.Next(_namePool.Count)];
            Location = _locationPool[_random.Next(_locationPool.Count)];
            Rank = _random.Next(1, 6);
            Status = "Going to die soon";
            AssignRandomWeapons();
        }

        private static Random _random = new Random();

        private static List<string> _namePool = new List<string>
        {
            "Ali", "Omar", "Sami", "Yousef", "Hassan",
            "Khaled", "Mahmoud", "Tariq", "Fadi", "Ziad"
        };


        private void AssignRandomWeapons()
        {
            List<string> weaponPool = new List<string> { "AKM", "Gun", "Knife" };


            weaponPool = weaponPool.OrderBy(w => _random.Next()).ToList();

            Weapons = new List<string>();
            Weapons.Add(weaponPool[0]);


            if (_random.NextDouble() < 0.5)
                Weapons.Add(weaponPool[1]);


            if (_random.NextDouble() < 0.5)
                Weapons.Add(weaponPool[2]);
        }

        private static List<string> _locationPool = new List<string>
        {
            "home", "car", "outside"
        };

        public override string ToString()
        {
            return $"Name: {Name}, Rank: {Rank}, Status: {Status}, Weapons: {string.Join(", ", Weapons)}, Location: {Location}, DangerLevel: {DangerLevel}";
        }
    }

}
