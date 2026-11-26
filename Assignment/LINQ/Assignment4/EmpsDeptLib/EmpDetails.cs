using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpsDeptLib
{
    public class EmpDetails
    {
        List<Employee> emps = new List<Employee>
        {
            new Employee() {Name="Ayesha", Department="HR" },
            new Employee() {Name="Saniya", Department="Training" },
            new Employee() {Name="Vanshika", Department="Development" },
            new Employee() {Name="Niyati", Department="Training" },
            new Employee() {Name="Muskan", Department="Training" },
            new Employee() {Name="Priya", Department="Development" }
        };

        public List<Employee> GetEmpList()
        {
            return emps;
        }
    }
}
