using System;
using System.Collections.Generic;
using System.Text;

namespace ReportModels
{
    public class Product
    {
        //public Product(Suppliers supplier, Category category)
        //{
        //    Supplier = supplier;
        //    Category = category;
        //}

        public int Id {get; set;}
        public int SuppliersId { get; set; }
        public Suppliers Supplier { get; set; }
        public string ProductName {get; set;}
        public double UnitPrice {get; set;}
       public virtual int CategoryId { get; set; }
        public virtual Category Category { get; set; } 
        public ICollection<OrderDetails> OrderDetail { get; set; }

    }
}
