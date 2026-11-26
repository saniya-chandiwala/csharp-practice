using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLib
{
    public class Student
    {
        int studentId;
        string studentName;

        // method to calculate total marks (addition of all subjects marks)
        public int CalculateTotal(int englishMarks, int mathsMarks, int scienceMarks)
        {
            return englishMarks + mathsMarks + scienceMarks;
        }

        // method to calculate average marks (all subject marks total/no. of subjects)
        public int CalculateAverage(int englishMarks, int mathsMarks, int scienceMarks)
        {
            return CalculateTotal(englishMarks, mathsMarks, scienceMarks) / 3;
        }

        // method to display results (pass if average >=35 else Fail)
        public string DisplayResult(int englishMarks, int mathsMarks, int scienceMarks)
        {
            if (CalculateAverage(englishMarks, mathsMarks, scienceMarks) > 35)
            {
                return "PASS";
            }
            else
            {
                return "FAIL";
            }
        }
    }
}
