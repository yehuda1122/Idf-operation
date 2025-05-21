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
        //public string getAttackname()
        //{
        //    return AttackName;
        //}
        //public void setAttackName(string attackName)
        //{ AttackName  = attackName; }

        int AmountOfAttacks { get; }
        //public int getamountOfAttacks()
        //    { return AmountOfAttacks; }
        //public void setAmountOfAttacks(int amountOfAttacks)
        //    { AmountOfAttacks = amountOfAttacks; }
        float AmountOfFuel { get; }
        //public float getamountOfFuel()
        //    { return AmountOfFuel; }
        //public void setAmountOfFuel(float amountOfFul)
        //{ AmountOfFuel = amountOfFul; }
        List<string> TypeOfTarget { get; }
    }

    class F16 : IAttackOptions
    {
        public string AttackName => "F16";
        public int AmountOfAttacks => 8;
        public float AmountOfFuel => 50;
        public List<string> TypeOfTarget => new List<string> { "building" };

        private string BoomType = "0.5 ton or 1 ton";
    }



    class Zik : IAttackOptions
    {
        public string AttackName => "zik";
        public int AmountOfAttacks => 3;
        public float AmountOfFuel => 25;
        public List<string> TypeOfTarget => new List<string> { "vehicle", "uhumen" };


    }
    class Artillery : IAttackOptions
    {
        public string AttackName => "Artillery";
        public int AmountOfAttacks => 40;
        public float AmountOfFuel => 30;
        public List<string> TypeOfTarget => new List<string> { "open space" };

        private string BoomType = "Explosive shells";
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

