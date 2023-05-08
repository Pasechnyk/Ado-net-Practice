using BookShop.DatabaseData;
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

// Exam Task - Create Book Shop Application

// Contains:
// - login system
// - books manager panel
// - sales and discounts manager panel

namespace BookShop
{
    public partial class Form1 : Form
    {
        // data usage
        BookShopDbContext context = new BookShopDbContext();
        List<User> users = new List<User>();

        public Form1()
        {
            InitializeComponent();

            SetUsers();
        }

        public void SetUsers()
        {
            foreach (var user in context.Users)
            {
                users.Add(new User()
                {
                    Id = user.Id,
                    Login = user.Login,
                    Password = user.Password
                });
            }
        }

        // Log in
        private void EnterBtnClick(object sender, EventArgs e)
        {
            var password = passTextBox.Text;

            if (userComboBox.SelectedItem == null || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Access denied: \n - fields are empty.");
                return;
            }

            if (password == "0000")
            {
                MainPanel form = new MainPanel();
                
                form.ShowDialog();
            }
            else if (password == "1111")
            {
                SalesPanel form = new SalesPanel();
                
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Access denied: \n - incorrect password.");
                return;
            }
        }

        // Exit the program
        private void ExitBtnClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
