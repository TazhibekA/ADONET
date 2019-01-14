using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLevelDB
{
    class AuthorContext:DbContext
    {
        public AuthorContext()
    : base("ItemsConnectionString")
        { }

        public DbSet<Author> Authors { get; set; }
    }
}
