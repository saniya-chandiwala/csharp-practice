using LibraryMngmntSysLib;
using System;
using System.Collections.Generic;

#region 
///<summary>
/// Q2. Library Management System 
/// Note: Do not use LINQ for this question.
/// 
/// A library wants to develop a simple application to manage its books.
/// The library maintains information such as book ID, title, author, price, and category.
/// 
/// The librarian should be able to 
/// add new books, 
/// search for a particular book, 
/// find books based on different criteria, 
/// -- display information such as books written by a particular author, 
/// -- books belonging to a particular category, 
/// -- and books whose price is above a specified amount
/// update book information, 
/// remove a book, 
/// display all available books, 
/// and arrange books in ascending order of title.
///</summary>
#endregion

public partial class LibraryForm : System.Web.UI.Page
{
    BookData data = new BookData();
    List<Book> books;
    Book book;

    int id;
    string title, author, category;
    double price;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    // adding new books
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        try
        {
            books = data.GetBooksData();

            id = Convert.ToInt32(txtId.Text);
            price = Convert.ToDouble(txtPrice.Text);
            title = txtTitle.Text;
            author = txtAuthor.Text;
            category = txtCategory.Text;

            // validating input
            if (id > 0 && price > 0 && !string.IsNullOrWhiteSpace(title) && !string.IsNullOrWhiteSpace(author) && !string.IsNullOrWhiteSpace(category))
            {
                // checking book exists
                if (books.Exists(x => x.BookId == id))
                {
                    lblMsg.Text = "Book Already Exists";
                }
                // adding book
                else
                {
                    book = new Book() { BookId = id, Author = author, Title = title, Category = category, Price = price };

                    data.AddBook(book);
                    lblMsg.Text = "Book Added Successfully";
                }
            }
            else
            {
                lblMsg.Text = "Couldn't Add Book, Invaild Data Entered";
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    // finding books based on different criteria
    protected void btnFind_Click(object sender, EventArgs e)
    {
        try
        {
            books = data.GetBooksData();

            // criteria based on which books are to be found
            switch (ddlCriteria.SelectedValue)
            {
                // based on id
                case "id":
                    lblFindMsg.Text = "";
                    id = Convert.ToInt32(txtSearchData.Text);

                    // finding book
                    book = books.Find(x => x.BookId == id);

                    if (book != null)
                    {
                        lblFindMsg.Text = "Book Id: " + book.BookId + "<br/>Title: " + book.Title + "<br/>Author: " + book.Author + "<br/>Category: " + book.Category + "<br/>Price: " + book.Price;
                    }
                    else
                    {
                        lblFindMsg.Text = "Book Not Found";
                    }

                    break;

                // based on title
                case "title":
                    lblFindMsg.Text = "";
                    title = txtSearchData.Text;

                    // finding all books with same title
                    List<Book> titleBooks = books.FindAll(x => x.Title.ToLower() == title.ToLower());

                    if (titleBooks.Count > 0)
                    {
                        lblFindMsg.Text = data.DisplayAll(titleBooks);
                    }
                    else
                    {
                        lblFindMsg.Text = "No Book Found";
                    }
                    break;

                // based on author
                case "author":
                    lblFindMsg.Text = "";
                    author = txtSearchData.Text;

                    // finding all books with same author
                    List<Book> authorBooks = books.FindAll(x => x.Author.ToLower() == author.ToLower());
                    if (authorBooks.Count > 0)
                    {
                        lblFindMsg.Text = data.DisplayAll(authorBooks);
                    }
                    else
                    {
                        lblFindMsg.Text = "No Book Found";
                    }
                    break;

                // based on category
                case "category":
                    lblFindMsg.Text = "";
                    category = txtSearchData.Text;

                    // finding all books with under same category
                    List<Book> categoryBooks = books.FindAll(x => x.Category.ToLower() == category.ToLower());
                    if (categoryBooks.Count > 0)
                    {
                        lblFindMsg.Text = data.DisplayAll(categoryBooks);
                    }
                    else
                    {
                        lblFindMsg.Text = "No Book Found";
                    }
                    break;

                // based on price
                case "price":
                    lblFindMsg.Text = "";
                    price = Convert.ToDouble(txtSearchData.Text);

                    // finding all books with price greater than or equal to entered amount
                    List<Book> priceBooks = books.FindAll(x => x.Price >= price);
                    if (priceBooks.Count > 0)
                    {
                        lblFindMsg.Text = data.DisplayAll(priceBooks);
                    }
                    else
                    {
                        lblFindMsg.Text = "No Book Found";
                    }
                    break;
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    // loading alreading existing data in textboxes
    protected void btnLoad_Click(object sender, EventArgs e)
    {
        try
        {
            books = data.GetBooksData();

            id = Convert.ToInt32(txtId.Text);

            book = books.Find(x => x.BookId == id);

            if (book != null)
            {
                txtTitle.Text = book.Title;
                txtAuthor.Text = book.Author;
                txtCategory.Text = book.Category;
                txtPrice.Text = book.Price.ToString();

                lblMsg.Text = "Book Loaded Successfully";
            }
            else
            {
                lblMsg.Text = "Book Not Found";
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    // updating book information
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        try
        {
            books = data.GetBooksData();

            id = Convert.ToInt32(txtId.Text);
            price = Convert.ToDouble(txtPrice.Text);
            title = txtTitle.Text;
            author = txtAuthor.Text;
            category = txtCategory.Text;

            if (id > 0 && price > 0 && !string.IsNullOrWhiteSpace(title) && !string.IsNullOrWhiteSpace(author) && !string.IsNullOrWhiteSpace(category))
            {
                // finding book if entered data is vaild
                book = books.Find(x => x.BookId == id);

                // updating book if book exists
                if (book != null)
                {
                    book = new Book() { BookId = id, Author = author, Title = title, Category = category, Price = price };

                    data.UpdateBook(book);
                    lblMsg.Text = "Book Updated Successfully";
                }
                else
                {
                    lblMsg.Text = "Book Not Found";
                }
            }
            else
            {
                lblMsg.Text = "Couldn't Update Book, Invaild Data Entered";
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    //removing a book
    protected void btnRemove_Click(object sender, EventArgs e)
    {
        try
        {
            books = data.GetBooksData();

            id = Convert.ToInt32(txtId.Text);

            // finding book
            book = books.Find(x => x.BookId == id);

            // remove if book exists
            if (id > 0 && book != null)
            {
                data.RemoveBook(book);
                lblMsg.Text = "Book Removed Succesfully";
            }
            else
            {
                lblMsg.Text = "Book Not Found";
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }

    }

    // display all available books
    protected void btnDisplay_Click(object sender, EventArgs e)
    {
        try
        {
            books = data.GetBooksData();
            lblDisplay.Text = data.DisplayAll(books);
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    //arrange books in ascending order of title
    protected void btnArranged_Click(object sender, EventArgs e)
    {
        try
        {
            books = data.GetBooksData();

            // sorted using comparable
            books.Sort();
            lblArranged.Text = data.DisplayAll(books);
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

}
