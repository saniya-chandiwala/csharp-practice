using System;

public partial class _Default : System.Web.UI.Page
{
    int[,] marks = { { 10, 20, 30 }, { 40, 50, 60 }, { 70, 80, 90 } };
    string[] names = { "Vanshika", "Ayesha", "Saniya" };
    string[] subjects = { "English", "Maths", "Science" };

    int Total(int index)
    {
        int total = 0;
        for (int i = 0; i < subjects.Length; i++)
        {
            total = total + marks[index, i];
        }
        return total;
    }

    double Average(int index)
    {
        return Total(index) / subjects.Length;
    }

    string Result(int index)
    {
        return Average(index) >= 40 ? "Pass" : "Fail";
    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnResult_Click(object sender, EventArgs e)
    {
        try
        {
            string result = "";

            for (int i = 0; i < names.Length; i++)
            {
                result = result + names[i] + "<br/>";

                for (int j = 0; j < subjects.Length; j++)
                {
                    result = result + subjects[j] + " : " + marks[i, j] + "<br/>";
                }

                result += "Total: " + Total(i) + "<br/>";
                result += "Average: " + Average(i) + "<br/>";
                result += "Result: " + Result(i) + "<br/>";

                result += "<hr/>";
            }

            lblResults.Text = result;
        }
        catch(Exception ex)
        {
            Response.Write(ex.Message);
        }

    }
}