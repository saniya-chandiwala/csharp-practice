namespace EmpPayrollLib
{
    public delegate void PayrollHandler();

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public double BasicSalary { get; set; }

        public void CalculateHRA()
        {
            BasicSalary = BasicSalary + (BasicSalary * 0.20);
        }

        public void CalculateDA()
        {
            BasicSalary = BasicSalary + (BasicSalary * 0.10);
        }

        public void CalculateTax()
        {
            BasicSalary = BasicSalary - (BasicSalary * 0.05);
        }
    }
}
