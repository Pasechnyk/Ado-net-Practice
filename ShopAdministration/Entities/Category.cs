using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAdministration.Entities
{
    public class Category
    {
		public int Id { get; set; }
		public string Name { get; set; }

		// navigation property
		public ICollection<Product> Products { get; set; }

		public override string ToString()
		{
			return Name;
		}
	}
}
