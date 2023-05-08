using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Publisher entity
namespace BookShop.Entities
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // navigation property
        public ICollection<Book> Books { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
