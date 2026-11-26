namespace ParamConsInBaseClass
{
    public class Developer : Employee
    {
        public string ProgrammingLanguage { get; }
        public int Experience { get; }

        public Developer (int id, string name, string dept, string lang, int exp) : base(id, name, dept)
        {
            ProgrammingLanguage = lang;
            Experience = exp;
        }
    }
}
