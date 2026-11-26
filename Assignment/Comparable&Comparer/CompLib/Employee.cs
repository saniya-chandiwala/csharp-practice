using System;

namespace CompLib
{
    public class Employee : IComparable<Employee>
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double EmpSalary { get; set; }

        public int CompareTo(Employee emp)
        {
            return EmpId.CompareTo(emp.EmpId);
        }
    }
}
