//A company has different types of employees.Create a base class Employee 
//    containing properties such as EmployeeId, Name, and Salary.
//    Create derived classes Developer and Manager.

//Add a method CalculateBonus() in the base class.
//Override the method in both derived classes with different bonus calculations.
//Create objects of Developer and Manager and display their details and bonuses.

namespace EmployeeManagementSystemLib
{
    public abstract class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }

        public abstract double CalculateBonus();
    }
}
