using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idf_operation
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<Terrorist> terrorists = CreateTerrorists(5); 

            
            Console.WriteLine("list of terrorist:\n");
            foreach (var terrorist in terrorists)
            {
                Console.WriteLine(terrorist);
            }
        }

       
        public static List<Terrorist> CreateTerrorists(int count)
        {
            List<Terrorist> terrorists = new List<Terrorist>();

            for (int i = 0; i < count; i++)
            {
                Terrorist t = new Terrorist();
                terrorists.Add(t);
            }

            return terrorists;
        }
    }
}