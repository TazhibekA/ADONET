using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class OrderGood
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int GoodId { get; set; }
        public int GoodCount { get; set; }

        public OrderGood(int id, int orderId, int goodId, int goodCount)
        {
            Id = id;
            OrderId = orderId;
            GoodId = goodId;
            GoodCount = goodCount;
        }
    }
}
