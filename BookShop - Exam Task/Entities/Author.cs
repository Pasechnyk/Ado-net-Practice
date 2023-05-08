using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author entity
namespace BookShop.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        [NotMapped]
        public string FullName => $"{Name} {Surname}";

        // navigation property
        public ICollection<Book> Books { get; set; }

        public override string ToString()
        {
            return FullName;
        }
    }
}
