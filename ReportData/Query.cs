using System;
using ReportData;
using Microsoft.EntityFrameworkCore;
using ReportModels;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ReportRepository
{
   public  class Query
    {
        
        public void GetSalesReport()
        {
            Console.WriteLine($" {"Sales Report:******",-15} ");
            DataContext dataContext = new DataContext();

            var salesReport = dataContext.Orders.Take(10).Include(e => e.OrderDetails).Select(e => new { Customers = e.Customer.FirstName  +" "+ e.Customer.LastName, amount = e.OrderDetails.Sum(a => a.UnitPrice)});

           




            Console.WriteLine($"{"Customer", -20} {"amount", -30}");
            foreach (var item in salesReport)
            {
                Console.WriteLine($"{item.Customers, -20} {item.amount, -30}");
            }
        }

        public void GetCustomerByCity()
        {
            DataContext dataContext = new DataContext();

            var CustByCity = dataContext.customers.AsEnumerable().GroupBy(x => x.Address.City);
            string fullname = "";
            string City = "";
            Console.WriteLine($"{"Name",-20} {"City",-20}");
            foreach (var item in CustByCity)
            {
                foreach (var a in item)
                {
                    fullname = a.FirstName + " "+ a.LastName;
                    Console.WriteLine($"{fullname,-20} {item.Key,-20}");
                }
                City = item.Key;
               
            }
            
            
        }

        public void GetTopDeal()
        {
            Console.WriteLine("Top 10 Deals:*****", -10);
            DataContext dataContext = new DataContext();
            var topDeals = dataContext.OrderDetails.Take(5).Include(x => x.Product).Include(y=>y.Order.Customer).OrderByDescending(a => a.Quantity);


            Console.WriteLine($"{"product Name", -20} {"Quantity", -10} {"Unit Price", -10 } {"Customer name", -10} { "shipdate", -10}");
            foreach (var item in topDeals)
            {
                Console.WriteLine($"{item.Product.ProductName, -20 } {item.Quantity,-10} {item.UnitPrice, -10 } {item.Order.Customer.FirstName, -10} {item.Order.Customer.LastName, -10} {item.ShipDate, -10}");
            }
        }

        public void GetCustomerAbove50k()
        {
            Console.WriteLine("Customers Above 50 Thousand order:*****", -10);
            DataContext dataContext = new DataContext();
            var TopCustomer = dataContext.Orders.Where(e => e.OrderDetails.Sum(e => e.UnitPrice) > 50000).Include(e => e.Customer).Include(e => e.OrderDetails);

            Console.WriteLine($"{"CUSTOMER NAME", -40} {"AMOUNT", -30}");
            Console.WriteLine();
            foreach (var item in TopCustomer)
            {
                Console.WriteLine($"{item.Customer.FirstName+" " + item.Customer.LastName, -40} {item.OrderDetails.Sum(e=>e.UnitPrice), -30}");
            }
        }

    }
}
