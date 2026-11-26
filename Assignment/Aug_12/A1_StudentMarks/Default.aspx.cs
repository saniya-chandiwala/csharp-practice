using System;

public partial class _Default : System.Web.UI.Page
{
    int[,] marks = { { 60, 70, 80, 90, 100 }, { 100, 50, 10, 30, 70 } };
    string[] names = { "vanshika", "ayesha", "saniya" };
    string[] subjects = { "english", "maths", "physics", "chemistry", "biology" };

    int CalculateTotal(int index)
    {
        int total = 0;
        for (int i = 0; i < subjects.Length; i++)
        {
            total = total + marks[index, i];
        }
        return total;
    }

    double CalculateAverage(int index)
    {
        return CalculateTotal(index) / 5;
    }

    int FindHighestScorer()
    {
        int highestIndex = 0;
        for (int i = 1; i < names.Length; i++)
        {
            if (CalculateTotal(i) > CalculateTotal(highestIndex))
            {
                highestIndex = i;
            }
        }
        return highestIndex;
    }


protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        string result = "";

        for (int i = 0; i < names.Length; i++)
        {
            result = result + names[i] + "<br/>";
            for (int j = 0; j < subjects.Length; j++)
            {
                result += subjects[j] + ": " + marks[i, j] + "<br/>";
            }
            result += "Total: " + CalculateTotal(i) + "<br/>";
            result += "Average: " + CalculateAverage(i) + "<br/>";
            result += "<hr/>";
        }
        lblStudents.Text = result;
    }


    protected void btnHighest_Click(object sender, EventArgs e)
    {
        int index = FindHighestScorer();
        lblHighest.Text = names[index]
                        + "<br/>Total: "
                        + CalculateTotal(index);
    }
}