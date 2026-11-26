using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighEmpLib
{
    public class EmpDetails
    {
        List<Employee> emps = new List<Employee>
        {
            new Employee() { Name="Ayesha", Salary=60000 },
            new Employee() { Name="Saniya", Salary=70000 },
            new Employee() { Name="Vanshika", Salary=80000 }
        };

        public List<Employee> GetEmpList()
        {
            return emps;
        }
    }
}
