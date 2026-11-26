using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompLib
{
    public class NameSal : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x.EmpName == y.EmpName)
            {
                //ASCENDING ---- x.EmpSalary.CompareTo(y.EmpSalary); 
                return y.EmpSalary.CompareTo(x.EmpSalary);
            }
            else
            {
                return x.EmpName.CompareTo(y.EmpName);
            }

            //int res;
            //res = x.EmpName.CompareTo(y.EmpName);

            //if (res == 0)
            //{
            //    return y.EmpSalary.CompareTo(x.EmpSalary);
            //}

            //return res;
        }
    }
}
