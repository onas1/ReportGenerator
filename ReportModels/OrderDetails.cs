using System;
using System.Collections.Generic;
using System.Text;

namespace ReportModels
{
    public class OrderDetails
    {
        public int Id { get; set; }
        public int OrderId { get; set; } 
        public Order Order { get; set; }
        public  virtual int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }

        public DateTime ShipDate { get; set; }
        //public ICollection<Product> products { get; set; } 
    }
}
