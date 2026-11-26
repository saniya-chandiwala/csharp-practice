using System;
using StudentPassedLib;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    StudentData data;
    List<Student> students;
    Student student;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        data = new StudentData();
        students = data.GetList();

        var passed = students.Where(x => x.Marks >= 40);
        foreach(Student s in passed)
        {
            lblPassed.Text += s.Id + " " + s.Name + " " + s.Marks + "<br/>";
        }

        var greaterMrks = passed.Where(x => x.Marks >= 80);
        foreach (Student s in greaterMrks)
        {
            lblScoreGreater.Text += s.Id + " " + s.Name + " " + s.Marks + "<br/>";
        }

        double avg = passed.Average(x => x.Marks);
        lblAvg.Text = avg.ToString();

        student = passed.OrderByDescending(x => x.Marks).First();
        lblHigh.Text = student.Id + " " + student.Name + " " + student.Marks + "<br/>";

        foreach (Student s in students)
        {
            lblOg.Text += s.Id + " " + s.Name + " " + s.Marks + "<br/>";
        }
    }
}