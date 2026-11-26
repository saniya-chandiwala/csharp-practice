using StudentLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

#region
/// <summary>
/// class to calculate and display students result
/// </summary>
#endregion

public partial class StudentForm : System.Web.UI.Page
{
    int englishMarks, mathsMarks, scienceMarks;
    int totalMarks, averageMarks;
    string result;

    Student s;

    protected void Page_Load(object sender, EventArgs e)
    {

    }


    // method to display results
    protected void btnResult_Click(object sender, EventArgs e)
    {
        try
        {
            s = new Student();
            englishMarks = Convert.ToInt32(txtEnglishMarks.Text);
            mathsMarks = Convert.ToInt32(txtMathsMarks.Text);
            scienceMarks = Convert.ToInt32(txtScienceMarks.Text);

            if (englishMarks >= 0 && mathsMarks >= 0 && scienceMarks >= 0)
            {
                totalMarks = s.CalculateTotal(englishMarks, mathsMarks, scienceMarks);
                lbTotalMarks.Text = totalMarks.ToString();

                averageMarks = s.CalculateAverage(englishMarks, mathsMarks, scienceMarks);
                lbAverageMarks.Text = averageMarks.ToString();

                result = s.DisplayResult(englishMarks, mathsMarks, scienceMarks);
                lbResult.Text = result;
            }
            else
            {
                lbResult.Text = "Invalid marks entered";
                lbAverageMarks.Text = "Cannot be calculated";
                lbTotalMarks.Text = "Cannot be calculated";
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}