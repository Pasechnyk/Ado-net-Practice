using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAdministration.Entities
{
    public class Position
    {
		public int Id { get; set; }
		public string Name { get; set; }

		// navigation property
		public ICollection<Worker> Workers { get; set; }
		public override string ToString()
		{
			return Name;
		}
	}
}
