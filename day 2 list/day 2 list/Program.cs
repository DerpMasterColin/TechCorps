using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_2_list
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> students = new List<string>();
            students.Add("John");
            students.Add("Thomas");
            students.Add("joseph");
            students.Add("Jacob");
            students.Add("Parker");

            for (int i = 0; i < students.Count; i++ )
            {
                Console.WriteLine(students[i]);

                foreach (string student in students) ;
                {
                    Console.WriteLine(students);
                }
            }
        }
    }
}
