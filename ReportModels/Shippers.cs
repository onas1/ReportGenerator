using System;
using System.Collections.Generic;
using System.Text;

namespace ReportModels
{
    public class Shippers
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

    }
}
