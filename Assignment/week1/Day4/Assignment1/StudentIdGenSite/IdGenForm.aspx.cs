using StudentIdGenLib;
using System;

public partial class IdGenForm : System.Web.UI.Page
{
    Student student;

    protected void Page_Load(object sender, EventArgs e)
    {
        student = new Student();
    }

    protected void btnGenerateId_Click(object sender, EventArgs e)
    {
        if(!string.IsNullOrWhiteSpace(txtName.Text) && !string.IsNullOrWhiteSpace(txtCourse.Text))
        {
            lbId.Text = student.GenerateId().ToString();
        }
        else
        {
            lbId.Text = "invalid data entered";
        }
    }
}