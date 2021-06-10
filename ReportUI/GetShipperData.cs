using System;
using ReportModels;
using System.Collections.Generic;
using System.Text;

namespace ReportUI
{
   public class GetShipperData
    {
        public static Shippers GetShipperSInfo()
        {

            Shippers shippers = new Shippers();
            Address address = new Address();

            //shippers.ShippersId = Guid.NewGuid().ToString();
            Console.Write("Enter Shipping Company's Name: ");
            shippers.CompanyName = Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            shippers.PhoneNumber = Console.ReadLine();
            Console.Write("Enter Street Name: ");
            address.StreetAddress = Console.ReadLine();
            Console.Write("Enter City: ");
            address.City = Console.ReadLine();
            Console.Write("Enter State: ");
            address.State = Console.ReadLine();
            Console.Write("Enter Country: ");
            address.Country = Console.ReadLine();
            shippers.Address = address;

            return shippers;


        }
    }
}
