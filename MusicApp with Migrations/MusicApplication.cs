using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using MusicApp.Entities;

// Task - Create Music Application using database with entities (Updated with Migrations)

namespace MusicApp
{
    public partial class MusicApplication : Form
    {
        // Data from entitites and data folders
        MusicAppDbContext db = new MusicAppDbContext();
        List<PlayList> playlists = new List<PlayList>();
        List<Track> tracks = new List<Track>();

        public MusicApplication()
        {
            InitializeComponent();
            UpdatePlaylistList();
        }
        private void UpdatePlaylistList()
        {
            playlistBox.DataSource = null;
            playlistBox.DataSource = playlists;
        }

        // Add playlist
        private void AddPlBtnClick(object sender, EventArgs e)
        {
            CreatePlayList form = new CreatePlayList();

            if (form.ShowDialog() == DialogResult.OK)
            {
                playlists.Add(form.PlayList);
                UpdatePlaylistList();
            }
        }

        // Populate playlist
        private void PlaylistBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            var playlist = playlistBox.SelectedItem as PlayList;
            if (playlist == null) { return; }

            playlistBox.DataSource = null;
            tracks.Clear();

            foreach (var track in playlist.Tracks)
            {
                tracks.Add(track);
            }

            playlistBox.DataSource = tracks;
        }

        // Linq to Entity Task 1 - Show most played track 
        private void MostListenedTrackBtnClick(object sender, EventArgs e)
        {
            playlistBox.DataSource = null;
            var mostPlayedSong = db.Tracks.Max(x => x.PlayCount);

            playlistBox.Items.Add(mostPlayedSong);
        }

        // Linq to Entity Task 2 - Show Top 3 tracks by artist
        private void Top3BtnClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                MessageBox.Show("No singer was given to search Top 3!");
            }

            string singer = searchTextBox.Text;
            if (playlistBox.Items.Contains($"{singer}"))
            {
                playlistBox.DataSource = null;
                playlistBox.DataSource = db.Tracks.Select(x => x).OrderByDescending(x => x.Rate).Take(3).ToList();
            }
        }

        // Linq to Entity Task 3 - Show songs which contain given part
        private void FindTracksByPartBtnClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                MessageBox.Show("Nothing to search!");
            }

            string songPart = searchTextBox.Text;
            if (playlistBox.Items.Contains($"{songPart}"))
            {
                playlistBox.DataSource = null;
                playlistBox.DataSource = db.Tracks.Select(x => x).Where(x => x.Name.Contains(songPart)).ToList();
            }
        }
    }
}
