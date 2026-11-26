namespace EmpPromLib
{
    public class EmpDetails
    {

        Employee[] employees = {
            new Employee() { Id = 1, Name = "saniya", Dept = "training", Salary = 51000},
            new Employee() {Id = 2, Name = "vanshika", Dept = "training", Salary = 50000 },
            new Employee() {Id = 3, Name = "ayesha", Dept = "training", Salary = 49000 }
        };

        public Employee GetEmployee(int id)
        {
            foreach(Employee emp in employees)
            {
                if(emp.Id == id)
                {
                    return emp;
                }
            }
            return null;
        }

        public Employee GetPromotedEmployee(Employee emp)
        {
            if (emp.Salary > 50000)
            {
                emp.Salary += (emp.Salary * 0.10);
                return emp;
            }
            return emp;
        }

    }
}
