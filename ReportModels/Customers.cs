using System;
using System.Collections.Generic;
using System.Text;

namespace ReportModels
{
    public class Customers
    {
     
        public int Id { get; set; } 

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public long Number { get; set; }
        public Address Address { get; set; }

        public ICollection<Order> order  { get; set; }


    }
}
