using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Transaction
    {
        public int Id { get; set; }
        public int OrderId{ get; set; }
 

        public Transaction(int id, int orderId)
        {
            Id = id;
            OrderId = orderId;
 
        }
    }
}
