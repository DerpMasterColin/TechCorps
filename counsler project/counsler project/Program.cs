using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace counsler_project
{
    class Program
    {
        static void Main(string[] args)
        {
            double watertemp;
            double airtemp;
            int probofrain;
            int timeofday;

            Console.Write("What is the water temperature in F?");
            watertemp = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is the air temperature in F?");
            airtemp = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is the chance of rain?");
            probofrain = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is the time of day (miitary)?");
            timeofday = Convert.ToInt32(Console.ReadLine());

            if (watertemp > 70 && probofrain < 30 && timeofday > 12 && timeofday < 16 && airtemp > 80) ;
            {
                Console.WriteLine("Take the kids swimming.");
            }
        }
    }
}


