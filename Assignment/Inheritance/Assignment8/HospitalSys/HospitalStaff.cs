namespace HospitalSys
{
    public abstract class HospitalStaff
    {
        public int StaffId { get; }
        public string StaffName { get; }

        public HospitalStaff(int id, string name)
        {
            StaffId = id;
            StaffName = name;
        }

        public abstract string PerformDuty();

        public string DisplayStaffDetails()
        {
            return "Id: " + StaffId + "<br/>Name: " + StaffName;
        }

        public virtual int CalculateSalary()
        {
            return 10;
        }
    }
}
