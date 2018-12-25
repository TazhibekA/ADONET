using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Good
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int ManufacturerId { set; get; }
        public int CategoryId { set; get; }
        public string Description { set; get;}
        public int Price { set; get; }

        public Good(int id, string name, int manufacturerId, int categoryId, string description, int price)
        {
            Id = id;
            Name = name;
            ManufacturerId = manufacturerId;
            CategoryId = categoryId;
            Description = description;
            Price = price;
        }
    }
}
