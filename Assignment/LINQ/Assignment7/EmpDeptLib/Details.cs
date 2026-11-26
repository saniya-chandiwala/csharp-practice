using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpDeptLib
{
    public class Details
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee() { EmpId = 101, EmpName = "Vanshika", DeptId = 1 },
            new Employee() { EmpId = 102, EmpName = "Priya", DeptId = 2 },
            new Employee() { EmpId = 103, EmpName = "Muskan", DeptId = 3 },
            new Employee() { EmpId = 104, EmpName = "Saniya", DeptId = 1 },
            new Employee() { EmpId = 105, EmpName = "Ayesha", DeptId = 2 }
        };

        List<Department> departments = new List<Department>
        {
            new Department() { DeptId = 1, DeptName = "IT" },
            new Department() { DeptId = 2, DeptName = "HR" },
            new Department() { DeptId = 3, DeptName = "Finance" }
        };

        public List<Employee> GetEmployeeList()
        {
            return employees;
        }

        public List<Department> GetDepartmentList()
        {
            return departments;
        }
    }
}
