using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Order
    {
        public int Id { get; set; } 
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public int TotalSum { get; set; }
        public DateTime Date { get; set; }
        public int StatusId { get; set; }

        public Order(int id,   int customerId, int employeeId, int totalSum, DateTime date, int statusId)
        {
            Id = id; 
            CustomerId = customerId;
            EmployeeId = employeeId;
            TotalSum = totalSum;
            Date = date;
            StatusId = statusId;
        }
    }
}
