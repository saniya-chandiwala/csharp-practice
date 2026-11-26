using System;

namespace StudentSysLib
{
    public class Student : IComparable<Student>
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public double Marks { get; set; }

        public int CompareTo(Student s)
        {
            return Marks.CompareTo(s.Marks);
        }
    }
}
