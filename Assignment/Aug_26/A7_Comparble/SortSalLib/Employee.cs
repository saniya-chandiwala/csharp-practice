using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//7. IComparable<T> – Sort Employees by Salary
//Scenario
//A company wants to display employees in ascending order of salary.

//Create an Employee class:

//EmployeeId
//EmployeeName
//Salary
//Implement:

//IComparable<Employee>
//The CompareTo() method should compare employees based on Salary.

//Create a List<Employee> containing at least 5 employees.

//Then:

//Display employees before sorting.
//Sort the list using Sort().
//Display employees after sorting.
namespace SortSalLib
{
    public class Employee : IComparable <Employee>
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public double Salary { get; set; }

        public int CompareTo(Employee other)
        {
            return Salary.CompareTo(other.Salary);
        }
    }
}
