namespace EmployeeManagementSystemLib
{
    public class Manager : Employee
    {
        public override double CalculateBonus()
        {
            return Salary * 0.20;
        }
    }
}
