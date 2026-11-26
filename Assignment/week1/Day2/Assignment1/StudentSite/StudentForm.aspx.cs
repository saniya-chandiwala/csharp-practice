using StudentLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region
/// <summary>
/// class to to store student details and calculate the total marks, average marks and results
/// </summary>
#endregion
public partial class StudentForm : System.Web.UI.Page
{
    Student s;
    int englishMarks, mathMarks, scienceMarks;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    // button to display output of total marks, average marks and results
    protected void btnResult_Click(object sender, EventArgs e)
    {
        try
        {
            s = new Student();

            englishMarks = Convert.ToInt32(txtEnglishMarks.Text);
            mathMarks = Convert.ToInt32(txtMathsMarks.Text);
            scienceMarks = Convert.ToInt32(txtScienceMarks.Text);

            if ((englishMarks >= 0 && englishMarks <= 100) && (scienceMarks >= 0 && scienceMarks <= 100) && (mathMarks >= 0 && mathMarks <= 100)) {

                s.EnglishMarks = englishMarks;
                s.MathsMarks = mathMarks;
                s.ScienceMarks = scienceMarks;

                lbTotalMarks.Text = s.CalculateTotal().ToString();
                lbAverageMarks.Text = s.CalculateAverage().ToString();
                lbResult.Text = s.DisplayResult();
            }
            else
            {
                lbResult.Text = "Invaild marks entered";
                lbAverageMarks.Text = "0";
                lbTotalMarks.Text = "0";
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}