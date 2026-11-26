using MovieLib;
using System;

public partial class RatingCompare : System.Web.UI.Page
{
    Movie m1;
    Movie m2;
    Movie higher;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCompare_Click(object sender, EventArgs e)
    {
        try
        {
            m1 = new Movie() { Title = "Dune", Genre = "Adv", Rating = 4 };
            m2 = new Movie() { Title = "Odyssey", Genre = "Action", Rating = 4 };

            lblMovie1.Text = "Title: " + m1.Title + "<br>Genre: " + m1.Genre + "<br>Rating: " + m1.Rating;
            lblMovie2.Text = "Title: " + m2.Title + "<br>Genre: " + m2.Genre + "<br>Rating: " + m2.Rating;

            higher = m1.CompareRating(m2);
            if (higher == null)
            {
                lblCompare.Text = "Both movies are Equal";
            }
            else
            {
                lblCompare.Text = "Movie with Higher Rating" + "<br>Title: " + higher.Title + "<br>Genre: " + higher.Genre + "<br>Rating: " + higher.Rating;
            }
        }
        catch(Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}