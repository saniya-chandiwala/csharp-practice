using ShapeSysLib;
using System;


//Create:


//Call Draw() using all four references.

//Task: Observe and explain the difference between overriding and hiding.

//Concept: Method overriding, method hiding, runtime polymorphism.



public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        
        Shape s1 = new Circle(); // Method Overriding based on OBJ TYPE
        Shape s2 = new Square(); // Method Shadowing/Hiding based on REF TYPE
        Shape s3 = new Shape();

        Circle c = new Circle();
        Square sq = new Square();

        Response.Write(s1.Draw() + "<br>");
        Response.Write(s2.Draw() + "<br>");
        Response.Write(s3.Draw() + "<br>");

        Response.Write(c.Draw() + "<br>");
        Response.Write(sq.Draw() + "<br>");

//OUTPUT :
//drawing CIRCLE
//draw SHAPE
//drawing CIRCLE
//drawing SQUARE

    }
}