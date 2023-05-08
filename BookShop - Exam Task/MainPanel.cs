using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookShop.Entities;
using BookShop.DatabaseData;

// Main administration panel

// Contains:
// - book adding/editing/removing
// - search by name/author/genre
// - data lists

namespace BookShop
{
    public partial class MainPanel : Form
    {
        // Data
        BookShopDbContext context = new BookShopDbContext();
        List<Author> authors = new List<Author>();
        List<Genre> genres = new List<Genre>();
        List<Book> books = new List<Book>();

        public MainPanel()
        {
            InitializeComponent();
            ShowContent();
            UpdateBooksListBox();
        }
        private void RefreshList(object sender, EventArgs e)
        {
            UpdateBooksListBox();
        }

        // Show books
        public void ShowContent()
        {
            booksListBox.DataSource = null;

            foreach (var b in context.Books.ToList())
            {
                books.Add(new Book()
                {
                    Id = b.Id,
                    Title = b.Title,
                    AuthorId = b.AuthorId,
                    Year = b.Year,
                    PagesCount = b.PagesCount,
                    Price = b.Price,
                    GenreId = b.GenreId,
                    PublisherId = b.PublisherId
                });
            }

            booksListBox.DataSource = books;
        }

        // Update books
        public void UpdateBooksListBox()
        {
            booksListBox.DataSource = null;
            booksListBox.DataSource = books;
        }

        // Add new book to the list
        private void AddBookBtnClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(titleTextBox.Text) ||
                authorNumeric.Value == 0)
            {
                MessageBox.Show("You have not completed entering data.");
                return;
            }

            Book book = new()
            {
                Id = (int)idNumeric.Value,
                Title = titleTextBox.Text,
                AuthorId = (int)authorNumeric.Value,
                Year = (int)yearNumeric.Value,
                GenreId = (int)genreNumeric.Value,
                PagesCount = (int)pagesNumeric.Value,
                PublisherId = (int)publisherNumeric.Value,
                Price = (int)priceNumeric.Value,
                Discount = 0
            };

            books.Add(book);
            UpdateBooksListBox();
        }

        // Remove book from list
        private void RemoveBookBtnClick(object sender, EventArgs e)
        {
            if (booksListBox.SelectedItem == null)
            {
                MessageBox.Show("You haven't selected any book to remove!");
                return;
            }
            var book = booksListBox.SelectedItem as Book;

            books.Remove(book);
            UpdateBooksListBox();
        }

        // Edit existing book
        private void EditBookBtnClick(object sender, EventArgs e)
        {
            var book = booksListBox.SelectedItem as Book;

            book.Id = (int)idNumeric.Value;
            book.Title = titleTextBox.Text;
            book.AuthorId = (int)authorNumeric.Value;
            book.Year = (int)yearNumeric.Value;
            book.GenreId = (int)genreNumeric.Value;
            book.PagesCount = (int)pagesNumeric.Value;
            book.PublisherId = (int)publisherNumeric.Value;
            book.Price = (int)priceNumeric.Value;

            UpdateBooksListBox();
        }

        // Find by given parameter
        private void FindByParameter(object sender, EventArgs e)
        {
            booksListBox.DataSource = null;
            var searchedText = searchTextBox.Text;

            // search by parameter
            if (sender == searchByNameBtn)
            {
                var nameString = books.Where(x => x.Title.Contains(searchedText)).ToList();

                booksListBox.DataSource = nameString;
            }
            else if (sender == searchByAuthorBtn)
            {
                var authorId = books.Where(x => x.AuthorId == Convert.ToInt32(searchedText)).ToList();

                booksListBox.DataSource = authorId;
            }
            else if (sender == searchByGenreBtn)
            {
                var genreString = books.Where(x => x.GenreId == Convert.ToInt32(searchedText)).ToList();

                booksListBox.DataSource = genreString;
            }
        }
    }
}
