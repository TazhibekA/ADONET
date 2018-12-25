using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cart
    {
        public int Id { get; set; } 
        public int CustomerId { get; set; } 
        public int TotalSum { get; set; }

        public Cart(int id, int customerId, int totalSum)
        {
            Id = id;
            CustomerId = customerId;
            TotalSum = totalSum;
        }
    }
}
