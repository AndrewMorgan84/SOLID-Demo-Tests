using System;
using SOLID.SRP;

namespace SOLID
{
    class Program
    {
        static void Main()
        {
            //SRP Test

            var s = new CalculateSalary() {DailyRate = 1000, Daysworked = 20};
            var salary = s.CalcaulateSalary();
            var p = new PrintSalary();
            p._PrintSalary(salary);
            Console.ReadKey(true);
        }
    }
}
