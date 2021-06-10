using System;
using ReportModels;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ReportData;
using System.Collections.ObjectModel;

namespace ReportUI
{
    public class GetProductData
    {
        public Product  GeProductInfo()
        {

            Category newcategory = new Category();
            Suppliers newsupplier = new Suppliers();
            Product product = new Product();
          
            DataContext dataContext = new DataContext();

            Console.Write("Enter product name: ");
           var productname = Console.ReadLine();
            Console.WriteLine($"Enter unit price of {product.ProductName} ");
           var productprice = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter category ID");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Supplier ID: ");
            int m = int.Parse(Console.ReadLine());

             newcategory = dataContext.Categories.Find(n);
             var supplier = dataContext.Suppliers.Find(m);
            product.ProductName = productname;
            product.UnitPrice = productprice;
            product.CategoryId = newcategory.Id;
            product.SuppliersId = supplier.Id;
            product.Category = newcategory;
            product.Supplier = newsupplier;

            //dataContext.products.Add(product);
            //dataContext.SaveChanges();
            return product;




           

            


           
            


        }
    }
}
