using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class UserContext:DbContext
    {
        public UserContext() : base("name=sitybook")
		{

		}
        public DbSet<User> Users { get; set; }
        public DbSet<Child> Children { get; set; }

    }
}
