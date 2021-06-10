using System;
using ReportModels;
using System.Collections.Generic;
using System.Text;

namespace ReportUI
{
    public class GetSupplierData
    {
        public static Suppliers GetSuppliersInfo()
        {
            Suppliers supplier = new Suppliers();
            Address address = new Address();

            //supplier.SuppliersId = Guid.NewGuid().ToString();

            Console.Write("Enter Supplier Company Name: ");
            supplier.SupplierCompanyName =Console.ReadLine();

            Console.Write("Enter Suppliers Phone Number: ");
            supplier.PhoneNumber = Console.ReadLine();
            Console.Write("Enter SUpplier Email Address: ");
            supplier.Email = Console.ReadLine();
            
            Console.Write("Enter supplier Street address");
            address.StreetAddress = Console.ReadLine();

            Console.Write("Enter Supplier City: ");
            address.City = Console.ReadLine();

            Console.WriteLine("Enter Supplier state: ");
            address.State = Console.ReadLine();

            Console.WriteLine("Enter Supplier Country: ");
            address.Country = Console.ReadLine();
           
            supplier.Address = address;
            

            return supplier;

            
        }
    }
}
