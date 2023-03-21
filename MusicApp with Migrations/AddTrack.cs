using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MusicApp.Entities;

// Child form - Add new tracks

namespace MusicApp
{
    public partial class AddTrack : Form
    {
        public Track Track { get; set; }
        public PlayList PlayList { get; set; }
        public AddTrack(PlayList playlist)
        {
            InitializeComponent();
            PlayList = playlist;
        }

        // Add new track
        private void AddTrackBtnClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(titleTextBox.Text) ||
                string.IsNullOrWhiteSpace(singerTextBox.Text) || 
                songNumeric.Value == 0 || string.IsNullOrWhiteSpace(genreTextBox.Text))
            {
                MessageBox.Show("Please finish entering all information!");
                return;
            }

            Track = new Track()
            {
                Name = titleTextBox.Text,
                Singer = new Singer() { Name = singerTextBox.Text },
                Duration = (int)songNumeric.Value,
                Genre = new Genre() { Name = genreTextBox.Text },
                Rate = (int)rateNumeric.Value,
                PlayCount = (int)countNumeric.Value,
                Lyrics = lyricsTextBox.Text,
                PlayList = PlayList
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Cancel addition
        private void CancelBtnClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
