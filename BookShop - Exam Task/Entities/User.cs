using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// User entity
namespace BookShop.Entities
{
    public class User
    {
        // user information
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return Login;
        }
    }
}
