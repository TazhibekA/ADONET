using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CartGood
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int GoodId { get; set; }
        public int GoodCount { get; set; }

        public CartGood(int id, int cartId, int goodId, int goodCount)
        {
            Id = id;
            CartId = cartId;
            GoodId = goodId;
            GoodCount = goodCount;
        }
    }
}
