using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLevelDB
{
    class UserContext : DbContext
    {
        public UserContext()
            : base("ItemsConnectionString")
        { }

        public DbSet<User> Users { get; set; }
    }
}
