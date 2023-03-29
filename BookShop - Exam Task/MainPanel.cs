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

namespace BookShop
{
    public partial class MainPanel : Form
    {
        List<Book> books = new List<Book>();
        public MainPanel()
        {
            InitializeComponent();
            UpdateBooksListBox();
        }

        public void UpdateBooksListBox()
        {
            booksListBox.DataSource = null;
            booksListBox.DataSource = books;
        }

        private void AddBookBtnClick(object sender, EventArgs e)
        {
            BookInfo form = new BookInfo();
            if (form.ShowDialog() == DialogResult.OK)
            {
                books.Add(form.Book);
                UpdateBooksListBox();
            }
        }

        private void RemoveBookBtnClick(object sender, EventArgs e)
        {
            if (booksListBox.SelectedItem == null)
            {
                MessageBox.Show("You haven't selected any book to remove!");
                return;
            }
            var item = booksListBox.SelectedItem as Book;

            books.Remove(item);

            UpdateBooksListBox();
        }

        //TODO
        private void EditBookBtnClick(object sender, EventArgs e)
        {

        }

        private void FindByNameBtnClick(object sender, EventArgs e)
        {

        }

        private void FindByAuthorBtnClick(object sender, EventArgs e)
        {

        }

        private void FindByGenreBtnClick(object sender, EventArgs e)
        {

        }
    }
}
