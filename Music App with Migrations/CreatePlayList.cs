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

// Child form - Create playlist option

namespace MusicApp
{
    public partial class CreatePlayList : Form
    {
        public PlayList PlayList { get; set; }
        List<Track> tracks = new List<Track>();

        public CreatePlayList()
        {
            InitializeComponent();
        }
        private void UpdateTrackList()
        {
            tracklistBox.DataSource = null;
            tracklistBox.DataSource = tracks;
        }

        // Add track into playlist
        private void AddBtnClcik(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(plTextBox.Text))
            {
                MessageBox.Show("Please finish entering all information!");
                return;
            }

            AddTrack form = new AddTrack(PlayList);

            if (form.ShowDialog() == DialogResult.OK)
            {
                tracks.Add(form.Track);
                UpdateTrackList();
            }
        }

        // Create playlist
        private void CreateBtnClick(object sender, EventArgs e)
        {
            if (tracklistBox.Items.Count == 0)
            {
                MessageBox.Show("No tracks to create playlist with");
                return;
            }

            this.DialogResult = DialogResult.OK;
            PlayList = new PlayList()
            {
                Name = plTextBox.Text,
                Tracks = tracks
            };

            this.Close();
        }

        // Remove track 
        private void RemoveBtnClick(object sender, EventArgs e)
        {
            if (tracklistBox.SelectedItem == null)
            {
                MessageBox.Show("You haven't selected a track to remove");
                return;
            }

            var item = tracklistBox.SelectedItem as Track;

            tracks.Remove(item);

            UpdateTrackList();
        }

        // Cancel playlist creation
        private void CancelBtnClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
