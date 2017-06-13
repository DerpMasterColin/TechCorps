using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_2_project_functions
{

    class Program
    {
        static string createnamestring(string firstname, string lastname)
        {
            string fullname = firstname + " " + lastname;
            return fullname;
        }

        static void givestudentgrade(string firstname, string lastname, int score)
        {
            string grade = "A";
            if (score > 79 && score < 90)
            {
                grade = "B";
            }
            else if (score > 69 && score < 80)
            {
                grade = "C";
            }
            else if (score > 59 && score < 70)
            {
                grade = "D";
            }
            else if (score > -1 && score < 60)
            {
                grade = "F";
            }
            Console.WriteLine(createnamestring(firstname, lastname) + ": " + grade);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(createnamestring("Iona", "Ford"));
            givestudentgrade("Tim", "Burr", 30);
            givestudentgrade("Al", "Dente", 99);
            givestudentgrade("Sue", "Flay", 91);
        }
    }
}

