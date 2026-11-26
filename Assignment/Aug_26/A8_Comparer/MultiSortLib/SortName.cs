using System;
using System.Collections.Generic;

namespace MultiSortLib
{
    public class SortName : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.EmployeeName.CompareTo(y.EmployeeName);
        }
    }
}
