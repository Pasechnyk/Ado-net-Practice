using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// City entity
namespace ShopAdministration.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }

        // navigation properties
        public ICollection<Shop> Shops { get; set; }
        public Country Country { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
