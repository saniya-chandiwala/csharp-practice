using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalcLib
{
    public class PermanentEmployee : ISalary
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public double CalculateSalary()
        {
            return Salary + (Salary * 0.10);
        }
    }
}
