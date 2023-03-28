using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public Genre Genre { get; set; }
        public Publisher Publisher { get; set; }
        public ICollection<Author> Authors { get; set; }
    }
}
