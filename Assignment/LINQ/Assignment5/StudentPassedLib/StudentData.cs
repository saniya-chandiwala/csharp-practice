using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPassedLib
{
    public class StudentData
    {
        List<Student> students = new List<Student>()
        {
            new Student() {Id=1, Name="Ayesha", Marks=60 },
            new Student() {Id=2, Name="Saniya", Marks=70 },
            new Student() {Id=3, Name="Vanshika", Marks=40 },
            new Student() {Id=4, Name="Alice", Marks=25 },
            new Student() {Id=5, Name="Bob", Marks=30 },
            new Student() {Id=6, Name="Muskan", Marks=90 }
        };

        public List<Student> GetList()
        {
            return students;
        }
    }
}
