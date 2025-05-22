using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idf_operation
{
    internal class Terrorist
    {
        protected string _name;
        private int _rank;
        private string _status;
        private string _wepon;
        private string _wepon2;
        private string _wepon3;
        private string _location;
        private int _dangerLavel;
        private static Random _random = new Random();

        public Terrorist(string name, string location)
        {
            _name = name;
            _rank = _random.Next(1, 6);
            _status = "Going to die soon";
            _location = location;
            assignRandomWeapons();
        }

        public void assignRandomWeapons()
        {
            List<string> _weaponPool = new List<string>
        {
            "AKM", "GUN", "Knife"
        };

            List<string> shuffledWeapons = new List<string>(_weaponPool);

            for (int i = 0; i < shuffledWeapons.Count; i++)
            {
                int j = _random.Next(i, shuffledWeapons.Count);
                string temp = shuffledWeapons[i];
                shuffledWeapons[i] = shuffledWeapons[j];
                shuffledWeapons[j] = temp;
            }

            _wepon = shuffledWeapons[0];
            _wepon2 = (_random.NextDouble() < 0.5) ? shuffledWeapons[1] : "";
            _wepon3 = (_random.NextDouble() < 0.5) ? shuffledWeapons[2] : "";
        }

        public string getname()
        {
            return _name;
        }

        public void setname(string name)
        {
            _name = name;
        }

        public int getrank()
        {
            return _rank;
        }

        public void setrank(int rank)
        {
            _rank = rank;
        }

        public string getstatus()
        {
            return _status;
        }

        //public void setstatus(bool status)
        //{
        //    _status = status;
        //}

        public string getwepon()
        {
            return _wepon;
        }

        public void setwepon(string wepon)
        {
            _wepon = wepon;
        }

        public string getwepon2()
        {
            return _wepon2;
        }

        public void setwepon2(string wepon2)
        {
            _wepon2 = wepon2;
        }

        public string getwepon3()
        {
            return _wepon3;
        }

        public void setwepon3(string wepon3)
        {
            _wepon3 = wepon3;
        }

        public string getlocation()
        {
            return _location;
        }

        public void setlocation(string location)
        {
            _location = location;
        }

        public int getdangerLavel()
        {
            return _dangerLavel;
        }
        public void setdangerLavel(int dangerLavel)
        {
            _dangerLavel = dangerLavel;
        }

        public string printTerrorist()
        {
            return $" {getname()} , {getrank()}, {getstatus()}, {getwepon()},{getwepon2()},{getwepon3()},{getlocation()} ";

        }
    }

}
