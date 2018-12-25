using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        public int Id { get; set; }
        public string FullName { set; get; }
        public int Age { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }

        public Employee(int id, string fullName, int age, string address, string phone)
        {
            Id = id;
            FullName = fullName;
            Age = age;
            Address = address;
            Phone = phone;
        }
    }
}
