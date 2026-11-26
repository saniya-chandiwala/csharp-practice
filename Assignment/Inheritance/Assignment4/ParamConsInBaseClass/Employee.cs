namespace ParamConsInBaseClass
{
    public class Employee
    {
        public int EmpId { get; }
        public string EmpName { get; }
        public string EmpDept { get; }

        public Employee(int id, string name, string dept)
        {
            EmpId = id;
            EmpName = name;
            EmpDept = dept;
        }
    }
}
