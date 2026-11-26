using BooksLib;
using System;

public partial class Library : System.Web.UI.Page
{
    Book book;
    BookDetails details;

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnIssue_Click(object sender, EventArgs e)
    {
        try
        {
            details = new BookDetails();

            book = details.GetBook(Convert.ToInt32(ddlBooks.SelectedValue));

            if(book!= null)
            {
                lblIssue.Text = "Book Succesfully Issued <br>" + "<br>Book Id: " + book.BookId + "<br>Book Name: " + book.BookTitle;
            }
            else
            {
                lblIssue.Text = "Book Already Issued";
            }
            

        }
        catch(Exception ex)
        {
            Response.Write(ex.Message);
        }
    }
}