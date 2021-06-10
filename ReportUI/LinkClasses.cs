using System;
using ReportData;
using ReportRepository;
using ReportModels;
using System.Collections.Generic;
using System.Text;

namespace ReportUI
{
   public class LinkClasses
    {

        public void LinkClass()
        {
            DataContext dataContext = new DataContext();
            Order order = new Order();
            Customers customers = dataContext.customers.Find();
            OrderDetails orderDetails = dataContext.OrderDetails.Find();
            Suppliers suppliers = dataContext.Suppliers.Find();
            Shippers shippers = dataContext.Shippers.Find();


            GetOrderDetailsData getOrderDetailsData = new GetOrderDetailsData();
            GetCategoryData getCategoryData = new GetCategoryData();
            GetSupplierData getSupplierData = new GetSupplierData();
            GetProductData getProductData = new GetProductData();
            GetCategoryData getCategoryData1 = new GetCategoryData();
            GetOrderData getOrderData = new GetOrderData();
            GetShipperData getShipperData = new GetShipperData();
            


            Order orders = new Order();
            Customers customer = new Customers();
            OrderDetails orderDetail = new OrderDetails();
            Suppliers supply = new Suppliers();
            Shippers ship = new Shippers();



            




            //customer.Address.StreetAddress = Console.ReadLine();
            //customer.Address.City = Console.ReadLine();
            //customer.Address.State = Console.ReadLine();
            //customer.Address.Country = Console.ReadLine();

            //customer.Email = Console.ReadLine();
            //customer.FirstName = Console.ReadLine();
            //customer.LastName = Console.ReadLine();
            //customer.Number = int.Parse(Console.ReadLine());
            //customer.order = ;


            //orderDetail = GetOrderDetailsData











        }
    }
}
