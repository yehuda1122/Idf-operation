using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asynctest
{
    internal class Program
    {
        static async Task bullidWater()
        {
            
            await Task.Delay(5000);
            
        }
        static void mikeCopTea()
        {
            Console.WriteLine("Preparing the tea throne");

        }
        static async Task Main(string[] args)
        {
            Console.WriteLine("start bullid");

            bullidWater();

            mikeCopTea();

            await bullidWater();

            Console.WriteLine("teh woter is bullid");
            Console.ReadKey();



        }
    }
}
