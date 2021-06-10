using System;
using System.Collections.Generic;
using System.Text;

namespace ReportModels
{
   public class Order
    {
        public int Id { get; set; }

        public virtual int  CustomerId { get; set; }
        public virtual Customers Customer { get; set; }
        public virtual int ShipperId { get; set; }
        public virtual Shippers Shipper { get; set; }
        public DateTime DateOrdered { get; set; }
        public int OrderNumber { get; set; }
        public string ShipDate { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }

    }
}
