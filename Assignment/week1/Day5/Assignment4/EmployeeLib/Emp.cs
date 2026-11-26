namespace EmployeeLib
{
    public class Emp
    {
        readonly int empId;
        public string EmpName { get; set; }
        public string EmpDept { get; set; }

        public Emp(int id, string name, string dept)
        {
            empId = id;
            EmpName = name;
            EmpDept = dept;
        }
    }
}
