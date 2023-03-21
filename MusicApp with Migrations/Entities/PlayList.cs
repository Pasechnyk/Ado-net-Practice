using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp.Entities
{
    public class PlayList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rate { get; set; }
        public ICollection<Track> Tracks { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
