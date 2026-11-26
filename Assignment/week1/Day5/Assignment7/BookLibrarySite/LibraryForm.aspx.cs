using BookLibraryLib;
using System;

public partial class LibraryForm : System.Web.UI.Page
{
    Book b;
    BookLibrary library;
    int id;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        try
        {
            library = new BookLibrary();

            id = Convert.ToInt32(txtSearch.Text);
            b = library.SearchBook(id);
            if (b != null)
            {
                lblDetails.Text = "Book Id: " + b.BookId + 
                    "<br>Book Name: " + b.Name + 
                    "<br> Book Price: " + b.Price;
            }
            else
            {
                lblDetails.Text = "invaild data found";
            }
        }

        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}