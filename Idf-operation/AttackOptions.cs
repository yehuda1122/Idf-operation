using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Idf_operation;

namespace Idf_operation
{
    public interface IAttackOptions
    {

        string AttackName { get; }
        int AmountOfAttacks { get; set; }
        float AmountOfFuel { get; set; }
        List<string> TypeOfTarget { get; }

        string BoomType { get; }
    }

    class F16 : IAttackOptions
    {
        public string AttackName => "F16";
        public int AmountOfAttacks { set; get; } = 8;
        public float AmountOfFuel { set; get; } = 50;
        public List<string> TypeOfTarget => new List<string> { "home" };

        public string BoomType => "0.5 ton or 1 ton";
    }



    class Zik : IAttackOptions
    {
        public string AttackName => "zik";
        public int AmountOfAttacks { set; get; } = 3;
        public float AmountOfFuel { set; get; } = 25;
        public List<string> TypeOfTarget => new List<string> { "car", "uhumen" };

        public string BoomType => "small roket";

    }
    class Artillery : IAttackOptions
    {
        public string AttackName => "Artillery";
        public int AmountOfAttacks { set; get; } = 40;
        public float AmountOfFuel { set; get; } = 30;
        public List<string> TypeOfTarget => new List<string> { "outside" };

        public string BoomType => "Explosive shells";
    }
    class idf
    {
        private string Time = "1948";
        private string Coomander;
        private string[] AttackOptions = new string[] { "F16", "Zik", "artillery" };

        public idf(string coomander )
        {
            Coomander = coomander;
        }
    }


}

