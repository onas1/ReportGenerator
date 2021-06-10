using System;
using System.Collections.Generic;
using System.Text;
using ReportModels;

namespace ReportUI
{
    public static class GetCustomerData
    {
        
        public static Customers GetCustomersInfo()
        {
            Address address = new Address();
            Customers customer = new Customers();
            Order order = new Order();
            OrderDetails orderDetail = new OrderDetails();
            Product product = new Product();
            Shippers shippers = new Shippers();


            Console.Write("Enter Customer First Name: ");
            customer.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            customer.LastName = Console.ReadLine();

            Console.Write("Enter Phone Number : ");
            customer.Number = long.Parse(Console.ReadLine());
            
            Console.Write("Enter email: ");
            customer.Email = Console.ReadLine();

            Console.Write("Enter Street Adress: ");
            address.StreetAddress = Console.ReadLine();

            Console.Write("Enter City: ");
            address.City = Console.ReadLine();

            Console.Write("Enter State: ");
            address.State = Console.ReadLine();

            Console.WriteLine("Enter Country: ");
            address.Country = Console.ReadLine();

            order.Customer = customer;
            order.CustomerId = customer.Id;
            order.DateOrdered = DateTime.Now;
            customer.Address = address;

            //order.OrderDetails = 

            return customer;

        }
        
    }
}
