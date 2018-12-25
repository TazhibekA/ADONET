using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class OrderStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public OrderStatus(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
