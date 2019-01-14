using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace AutoLevelDB
{
    class ArticleContext : DbContext
    {
        public ArticleContext()
          : base("ItemsConnectionString")
        { }

        public DbSet<Article> Articles { get; set; }
    }
}
