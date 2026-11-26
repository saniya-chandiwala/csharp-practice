using System;
using StudentSysLib;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MngmntSys : System.Web.UI.Page
{
    StudentDetails details = new StudentDetails();
    Student student;
    int id;
    string name;
    double mrks;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        student = new Student()
        {
            StudentId = Convert.ToInt32(txtId.Text),
            StudentName = txtName.Text,
            Marks = Convert.ToDouble(txtMarks.Text)
        };
        
        details.AddStudent(student);

        lblMsg.Text = "Student Added Succesfully";
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        id = Convert.ToInt32(txtFindId.Text);

        lblStudent.Text = details.FindStudent(id);
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        id = Convert.ToInt32(txtFindId.Text);

        lblStudent.Text = details.RemoveStudent(id);
    }

    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        lblAllStudents.Text = details.DisplayAll();        
    }

    protected void btnMrks_Click(object sender, EventArgs e)
    {
        lblMrksGreater.Text = details.MrksOver75();
    }

    protected void btnSorted_Click(object sender, EventArgs e)
    {
        lblSortedStudents.Text = details.SortByMrks();
    }
}