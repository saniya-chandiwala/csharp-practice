namespace EmpDeptLib
{
    public class EmpTransfer
    {
        Employee[] employees;
        
        public EmpTransfer()
        {
            employees = new Employee[]
            {
                new Employee() {EmpId=1, EmpName="Saniya", EmpDept = "Training" },
                new Employee() {EmpId=2, EmpName="Ayesha", EmpDept = "Training" },
                new Employee() {EmpId=3, EmpName="Vanhika", EmpDept = "HR" }
            };
        }

        public Employee GetEmployee(int id)
        {
            foreach (Employee emp in employees)
            {
                if (emp.EmpId == id)
                {
                    return TransferEmployee(emp);
                }
            }
            return null;
        }

        public Employee TransferEmployee(Employee emp)
        {
            if (emp.EmpDept == "Training")
            {
                emp.EmpDept = "Development";
                return emp;
            }
            return null;
        }
    }
}
