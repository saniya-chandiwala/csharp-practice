namespace HospitalSys
{
    public class Doctor : HospitalStaff
    {
        public Doctor (int id, string name) : base (id, name)
        {
        }

        public override string PerformDuty()
        {
            return "DOCTOR performs duty";
        }

        public sealed override int CalculateSalary()
        {
            return 1000;
        }
    }
}
