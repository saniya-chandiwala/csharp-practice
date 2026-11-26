using System;

public partial class _Default : System.Web.UI.Page
{
    // array of names
    string[] names = { "Amit", "Priya", "Rahul" };

    // jagged array of skills
    string[][] skills =
    {
        new string[] { "C#", "SQL", "Azure" },
        new string[] { "C#", "React" },
        new string[] { "C#", "SQL", ".NET", "Azure", "Power BI" }
    };

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    // button to display employee and thier skills
    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        // iterating thru names array
        for(int i = 0; i<names.Length; i++)
        {
            lblDisplay.Text += "<u>" + names[i] + "</u><br/>";

            // iterating thru skills array based on outer loops iteration
            for (int j = 0; j < skills[i].Length; j++)
            {
                lblDisplay.Text += skills[i][j] + "<br/>";
            }
            lblDisplay.Text += "<hr>";
        }
    }


    // button to search emp based on skill
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        for(int i = 0; i<names.Length; i++)
        {
            for(int j = 0; j<skills[i].Length; j++)
            {
                if(skills[i][j].ToLower() == txtSkill.Text.ToLower())
                {
                    lblResult.Text = names[i];
                }
            }
        }
    }
}