using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Book entity
namespace BookShop.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? AuthorId { get; set; }
        public int Year { get; set; }
        public int PagesCount { get; set; }
        public int Price { get; set; }
        public int? GenreId { get; set; }
        public int? PublisherId { get; set; }
        public int? Discount { get; set; }

        // navigation properties
        public Author Author { get; set; }
        public Genre Genre { get; set; }
        public Publisher Publisher { get; set; }

        public override string ToString()
        {
            return $"B-ID {Id} A-ID {AuthorId} G-ID {GenreId}   ||  " +
                $" {Title} - {Year} ({PagesCount} p.)" +
                $" {Price}$ / {Discount}%";
        }
    }
}
