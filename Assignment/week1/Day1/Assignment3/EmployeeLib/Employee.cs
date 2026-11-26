using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLib
{
    public class Employee
    {
        int empId;
        string empName;

        // method to calculate HRA 
        public double CalculateHRA(double basicSalary)
        {
            return basicSalary * 0.20;
        }

        // method to calculate DA
        public double CalculateDA(double basicSalary)
        {
            return basicSalary * 0.10;
        }

        // method to calculate Gross Salary
        public double CalculateGrossSalary(double basicSalary)
        {
            return basicSalary + CalculateHRA(basicSalary) + CalculateDA(basicSalary);
        }
    }
}
