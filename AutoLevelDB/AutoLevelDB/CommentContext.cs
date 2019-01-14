using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLevelDB
{
   public class CommentContext:DbContext
    {
        public CommentContext()
     : base("ItemsConnectionString")
        { }

        public DbSet<Comment> Comments { get; set; }
    }
}
