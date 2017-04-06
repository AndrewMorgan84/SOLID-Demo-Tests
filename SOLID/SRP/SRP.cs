using System;

namespace SOLID.SRP
{

    public class Salary
    {
        //The below code shows the wrong way to implement SRP

        public double PerDayRate { get; set; }
        public int NumberOfDays { get; set; }

        //1st responsibility to calculate salary!?
        public double CalculateSalary()
        {
            return PerDayRate*NumberOfDays;
        }

        //2nd responsibility to print the salary!?
        public void PrintSalary()
        {
            Console.WriteLine(PerDayRate*NumberOfDays);
        }

        //More than one responsibility would violate the SRP.
        
    }
}
