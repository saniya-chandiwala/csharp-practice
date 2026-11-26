namespace EMSLib
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double EmpSalary { get; set; }

        public Employee GetHighestPaidEmployee(Employee emp1, Employee emp2)
        {
            if(emp1.EmpSalary > emp2.EmpSalary)
            {
                return emp1;
            }
            else if (emp1.EmpSalary < emp2.EmpSalary)
            {
                return emp2;
            }
            return null;
        }

        public static double CalculateAnnualSalary( double sal)
        {
            return sal * 12;
        }

        static string companyName;
        static double workingHrs;
        static int retirementAge;

        static Employee()
        {
            companyName = "Inogic";
            workingHrs = 11;
            retirementAge = 101;
        }

        public static string DisplayConfiguration()
        {
            return "Company Name: " + companyName
                 + "<br/>Working Hours: " + workingHrs
                 + "<br/>Retirement Age: " + retirementAge;
        }

    }
}
