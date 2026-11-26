namespace Student
{
    public class StudentRegNo
    {
        readonly int regNo;
        public string StudentName;
        public string StudentCourse;

        public StudentRegNo(int num, string name, string course)
        {
            regNo = num;
            StudentName = name;
            StudentCourse = course;
        }
    }
}
