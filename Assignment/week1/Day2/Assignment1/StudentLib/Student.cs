using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLib
{
    #region
    /// <summary>
    /// class with method to calculate total and average marks and determine final result
    /// </summary>
    #endregion
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int EnglishMarks { get; set; }
        public int MathsMarks { get; set; }
        public int ScienceMarks { get; set; }

        // method to calculate total marks (addition of all subjects marks)
        public int CalculateTotal()
        {
            return EnglishMarks + MathsMarks + ScienceMarks; 
        }

        // method to calculate average marks (all subject marks total/no. of subjects)
        public int CalculateAverage()
        {
            return CalculateTotal() / 3;
        }

        // method to display results (pass if average >=35 else Fail)
        public string DisplayResult()
        {
            if (CalculateAverage() >= 35)
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
