using BookShop.DatabaseData;
using BookShop.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Sales and Discount manager panel

// Contains: 
// - billing informatioin
// - adding discounts to chosen books
// - bills/discount list save

namespace BookShop
{
    public partial class SalesPanel : Form
    {
        BookShopDbContext context = new BookShopDbContext();
        List<Book> books = new List<Book>();

        public SalesPanel()
        {
            InitializeComponent();
            ShowBooksListContent();
        }

        // Show content
        public void ShowBooksListContent()
        {
            booksSaleListBox.DataSource = null;

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
                    PublisherId = b.PublisherId,
                    Discount = b.Discount
                });
            }

            booksSaleListBox.DataSource = books;
        }

        // Print and save bill to directory
        private void PrintBillBtnClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(clientTextBox.Text) || 
                string.IsNullOrWhiteSpace(bookTitleTextBox.Text))
            {
                MessageBox.Show("You have not completed entering data.");
                return;
            }
            
            // saving
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.DefaultExt = ".txt";

            var book = booksSaleListBox.SelectedItem as Book;

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using(StreamWriter writer = new StreamWriter(saveFile.FileName))
                {
                    writer.WriteLine(clientTextBox.Text);
                    writer.WriteLine(bookTitleTextBox.Text);
                    writer.WriteLine(book.Year);
                    writer.WriteLine(amountNumeric.Value);
                    writer.WriteLine(book.Price * amountNumeric.Value);
                    writer.Close();
                }
            }

            MessageBox.Show($"\t------------- BILL SUCCESSFUL ----------------" +
                $"\nYour bill, {clientTextBox.Text}:" +
                $"\nBook title - {bookTitleTextBox.Text}" +
                $"\nYear - {book.Year}" +
                $"\nAmount of books - {amountNumeric.Value}" +
                $"\nTotal price - {book.Price * amountNumeric.Value}" +
                $"\n\t-------------------------------------------");
        }

        // Reset input data
        private void ResetBtnClick(object sender, EventArgs e)
        {
            clientTextBox.Text = " ";
            bookTitleTextBox.Text = " ";
            amountNumeric.Value = 1;
        }

        // Make a chosen book have a discount
        private void AddDiscountBtnClick(object sender, EventArgs e)
        {
            discountedBooksList.DataSource = null;

            if (booksSaleListBox.SelectedItem == null)
            {
                MessageBox.Show("No book was chosen.");
                return;
            }

            var book = booksSaleListBox.SelectedItem as Book;

            if (fivePercentBtn.Checked)
            {
                book.Discount = 5;
                book.Price = book.Price - (int)(book.Price * 0.05);
            }
            else if (tenPercentBtn.Checked)
            {
                book.Discount = 10;
                book.Price = book.Price - (int)(book.Price * 0.1);
            }
            else if (fifteenPercentBtn.Checked)
            {
                book.Discount = 15;
                book.Price = book.Price - (int)(book.Price * 0.15);
            }
            else if (twentyPercentBtn.Checked)
            {
                book.Discount = 20;
                book.Price = book.Price - (int)(book.Price * 0.2);
            }
            else { book.Discount = 0; }

            discountedBooksList.Items.Add(book);
        }

        // Reset discounts list
        private void ResetDiscountsBtnClick(object sender, EventArgs e)
        {
            discountedBooksList.Items.Clear();
        }

        // Save discounts list
        private void SaveDiscountsBtnClick(object sender, EventArgs e)
        {
            SaveFileDialog saveDiscountsFile = new SaveFileDialog();
            saveDiscountsFile.DefaultExt = ".txt";

            if (saveDiscountsFile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveDiscountsFile.FileName))
                {
                    foreach (var item in discountedBooksList.Items)
                    {
                        writer.WriteLine(item);
                    }
                    writer.Close();
                }
            }
            MessageBox.Show("Save is completed!");
        }
    }
}
