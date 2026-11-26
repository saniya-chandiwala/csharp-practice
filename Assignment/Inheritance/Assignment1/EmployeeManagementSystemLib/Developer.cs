namespace EmployeeManagementSystemLib
{
    public class Developer : Employee
    {
        public override double CalculateBonus()
        {
            return Salary * 0.10;
        }
    }
}
