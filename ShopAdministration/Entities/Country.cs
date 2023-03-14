using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Country entity
namespace ShopAdministration.Entities
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set;}

        // navigation property
        public ICollection<City> Cities { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
