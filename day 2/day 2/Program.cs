using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_2
{
    class Program
    {
        static string askquestion(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
        static void Main(string[] args)
        {
            double temperature;

            temperature = Convert.ToDouble(askquestion("what is the temp in degrees F."));
            
                if (temperature <= 80)
                {
                Console.WriteLine("play frisbee");
                    
                }
            else
            {
                string waterwarm = askquestion("Is the water warm?");
                if ((temperature > 80) && (waterwarm == "y"))
                {
                    Console.WriteLine("go swimming");
                }
                else
                {
                    Console.WriteLine("play frisbee");
                }
            }
            




        }
    }
}
