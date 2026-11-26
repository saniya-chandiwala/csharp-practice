using System;
using System.Collections.Generic;

namespace MultiSortLib
{
    public class SortSalary : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Salary.CompareTo(y.Salary);
        }
    }
}
