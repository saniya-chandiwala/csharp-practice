namespace SalaryComparisonLib
{
    public class Salary
    {
        public Employee CompareSalary(Employee emp1, Employee emp2)
        {
            return emp1.Salary > emp2.Salary ? emp1 : emp2;
        }
    }
}
