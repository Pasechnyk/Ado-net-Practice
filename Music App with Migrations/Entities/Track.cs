using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MusicApp.Entities
{
    public class Track
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Album Album {get; set;}
        public int Duration { get; set; }
        public int Rate { get; set; }
        public int PlayCount { get; set; }
        public string Lyrics { get; set; }


        [ForeignKey("SingerId")]
        public Singer Singer { get; set; }
        [ForeignKey("GenreId")]
        public Genre Genre { get; set; }
        [ForeignKey("PlaylistId")]
        public PlayList PlayList { get; set; }

        // update: add playlists collection
        public ICollection<PlayList> PlayLists { get; set; }

        public override string ToString()
        {
            return $"{Id + 1} {Name} {Singer.Name} {Album} {Genre.Name} {Duration}minutes.\n" +
                $"{Rate}-rate, Played {PlayCount} times, Lyrics - '{Lyrics}' ";
        }
    }
}
