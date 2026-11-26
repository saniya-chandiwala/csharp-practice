using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalFilterLib
{
    public class EmployeeDetails
    {
        List<Employee> emps = new List<Employee>
        {
            new Employee() {Id=1, Name="Ayesha", Department="HR", Salary=60000 },
            new Employee() {Id=2, Name="Saniya", Department="Training", Salary=70000 },
            new Employee() {Id=3, Name="Vanshika", Department="Development", Salary=50000 }
        };

        public List<Employee> GetEmpList()
        {
            return emps;
        }
    }
}
