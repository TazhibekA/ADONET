using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoLevelDB
{
    public class Comment 
    {
        public int ID { get; set; }
        public int ID_new { get; set; }
        public int ID_user { get; set; }
        public string Text { get; set; }
        public DateTime DateTime { get; set; }
    }
}
