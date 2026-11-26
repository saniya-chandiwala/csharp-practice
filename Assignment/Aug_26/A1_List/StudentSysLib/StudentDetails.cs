using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSysLib
{
    public class StudentDetails
    {
        static List<Student> students = new List<Student>();

        // add student
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        // display single student
        public string DisplayStudent(Student s)
        {
            return "Student Id: " + s.StudentId + " Student Name: " + s.StudentName + " Marks: " + s.Marks + "<br>";
        }

        // display all students
        public string DisplayAll()
        {
            string result = null;
            result += "Number of Students: " + students.Count + "<br><br>";

            foreach (Student s in students)
            {
                result += DisplayStudent(s);
            }
            
            return result;
        }

        // students with marks over 75
        public string MrksOver75()
        {
            string result = null;
            List<Student> filterdStudents = students.FindAll(x => x.Marks >= 75);

            if(filterdStudents.Count == 0)
            {
                return "Not Found";                             
            }
            else
            {
                foreach (Student s in filterdStudents)
                {
                    result += DisplayStudent(s);
                }
            }
            return result;

        }

        // find by id
        public string FindStudent(int id)
        {
            Student s = students.Find(x => x.StudentId == id);

            if(s!= null)
            {
                return DisplayStudent(s);
            }
            return "Student Not Found";         
        }

        // remove using id
        public string RemoveStudent(int id)
        {
            Student s = students.Find(x => x.StudentId == id);

            if (s != null)
            {
                students.Remove(s);
                return "Student Removed Succesfully";
            }
            return "Student Not Found";
        }

        // sort according to marks
        public string SortByMrks()
        {
            students.Sort();
            string result = null;

            foreach (Student s in students)
            {
                result += DisplayStudent(s);
            }

            return result;
        }
    }
}
