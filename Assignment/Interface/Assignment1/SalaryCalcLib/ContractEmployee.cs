using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryCalcLib
{
    public class ContractEmployee : ISalary
    {
        public string Name { get; set; }
        public int NoOfHours { get; set; }
        public double PerHourPay { get; set; }

        public double CalculateSalary()
        {
            return NoOfHours * PerHourPay;
        }
    }
}
