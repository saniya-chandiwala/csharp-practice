using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpSalaryLib
{
    #region
    /// <summary>
    /// class with methods to calculate HRA and DA applicable on salary and Gross Salary
    /// </summary>
    #endregion
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public double BasicSalary { get; set; }

        // method to calculate HRA (20% of basic salary)
        public double CalculateHRA()
        {
            return BasicSalary * 0.20;
        }

        // method to calculate DA (10% of basic salary)
        public double CalculateDA()
        {
            return BasicSalary * 0.10;
        }

        // method to calculate Gross Salary (basic salary + HRA + DA)
        public double CalculateGrossSalary()
        {
            return BasicSalary + CalculateHRA() + CalculateDA();
        }
    }
}
