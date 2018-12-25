using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Manufacture
    {
        public int Id { set; get; }
        public string Name { get; set; }

        public Manufacture(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
