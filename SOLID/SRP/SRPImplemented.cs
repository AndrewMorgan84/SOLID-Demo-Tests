using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    //The right way would be to refactor the code as such

    public class CalculateSalary
    {
        public double DailyRate { get; set; }
        public int Daysworked { get; set; }

        public double CalcaulateSalary()
        {
            return DailyRate * Daysworked;
        }

        //This class now only has one responsibility - to calculate the salary
    }

    public class PrintSalary
    {
        public void _PrintSalary(double salary)
        {
            Console.WriteLine(salary);
        }

        //This class now only has one responsibility - to print the salary
    }
}
