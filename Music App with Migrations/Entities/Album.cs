using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Update: added Album class

namespace MusicApp.Entities
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        [ForeignKey("GenreId")]
        public Genre Genre { get; set; }
        public int Rate { get; set; }

        public ICollection<Track> Tracks { get; set; }
    }
}
