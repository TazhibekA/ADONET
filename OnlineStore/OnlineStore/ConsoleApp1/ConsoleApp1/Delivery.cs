using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Delivery
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
  

        public Delivery(int id, int orderId )
        {
            Id = id;
            OrderId = orderId;
           
        }
    }
}
