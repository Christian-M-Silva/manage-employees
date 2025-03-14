using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageEmployees.models
{
    public class EmployerPj(string name, double baseSalary, int workHours) : Employees(name, baseSalary)
    {
        public int WorkHours { get; set; } = workHours;

        public override void CalculateSalary()
        {
            double finalSalary = WorkHours * BaseSalary;
            Console.WriteLine($"{Name} trabalhou {WorkHours}:00. Sendo o seu sálario R${BaseSalary}, terá como sálario final {finalSalary}.");
        }
    }
}
