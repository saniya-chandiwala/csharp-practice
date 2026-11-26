using System;
using System.Collections.Generic;

namespace MultiSortLib
{
    public class SortDept : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Department.CompareTo(y.Department);
        }
    }
}
