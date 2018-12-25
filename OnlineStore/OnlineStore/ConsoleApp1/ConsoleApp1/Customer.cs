using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Customer
    {
        public int Id { get; set; }
        public string FullName { set; get;}
        public int Age { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }

        public Customer(int id, string fullName, int age, string address, string phone)
        {
            Id = id;
            FullName = fullName;
            Age = age;
            Address = address;
            Phone = phone;
        }
    }
}
