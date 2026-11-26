using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
//3. Employee Salary Update

//An HR application allows administrators to update employee salaries.

//Requirements:

//Create an Employee class with EmployeeId, Name, and Salary.
//Create a SalaryChanged event.
//When the salary changes, notify:
//HR department
//Finance department
//Employee
//Question:
//How can one event notify multiple subscribers?

//Follow-up:
//Would you use a singlecast or multicast delegate internally?
namespace EmpSalUpdtLib
{
    public delegate void SalChangeDel();

    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double EmpSalary { get; set; }

        public event SalChangeDel SalChangeEvent;

        public void ChangeSalary(double changedSal)
        {
            if(EmpSalary != changedSal)
            {
                EmpSalary = changedSal;
                
                if(SalChangeEvent != null)
                {
                    SalChangeEvent();
                }
                else
                {
                    HttpContext.Current.Response.Write("Event Handler not attach to event");
                }
            }
            else
            {
                HttpContext.Current.Response.Write("Salary is Same");
            }

        }
    }
}
