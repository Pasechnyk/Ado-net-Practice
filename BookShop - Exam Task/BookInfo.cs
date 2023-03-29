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

namespace BookShop
{
    public partial class BookInfo : Form
    {
        List<Genre> genres = new List<Genre>();
        public Book Book { get; set; }
        public BookInfo()
        {
            InitializeComponent();
            LoadGenresComboBox();
        }

        public void LoadGenresComboBox()
        {
            genreComboBox.DataSource = null;
            genreComboBox.DataSource = genres;
        }

        // TODO
        private void ConfirmBtnClick(object sender, EventArgs e)
        {

        }

        private void CancelBtnClick(object sender, EventArgs e)
        {
            this.Close();
            MainPanel form = new MainPanel();
        }
    }
}
