using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MusicApp.Entities
{
    public class Singer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey("CountryId")]
        public Country Country { get; set; }
        public ICollection<Track> Tracks { get; set; }
    }
}
