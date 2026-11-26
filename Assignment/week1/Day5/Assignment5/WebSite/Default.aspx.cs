using Student;
using System;

public partial class _Default : System.Web.UI.Page
{
    StudentRegNo s;
    int id; 

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        id = Convert.ToInt32(txtId.Text);
        s = new StudentRegNo(id, txtName.Text, txtCourse.Text);

        lblDetails.Text = "Student Id: " + id + "<br>Student Name: " + s.StudentName + "Student Course: " + s.StudentCourse;
    }
}