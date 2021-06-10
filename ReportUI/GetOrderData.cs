using System;
using ReportModels;
using System.Collections.Generic;
using System.Text;
using ReportData;

namespace ReportUI
{
    public class GetOrderData
    {
        public static Order GetOrderInfo()
        {
            DataContext dataContext = new DataContext();
            Customers customer = new Customers();
            Order order = new Order();
            Shippers shipper = new Shippers();
            OrderDetails orderDetail = new OrderDetails();
            
            customer  = dataContext.customers.Find(3);
            order = dataContext.Orders.Find(3);
            shipper = dataContext.Shippers.Find(1);
            orderDetail = dataContext.OrderDetails.Find(11);

            order.Customer = customer;
            order.CustomerId = customer.Id;
            order.OrderNumber += orderDetail.Id;
            order.Shipper = shipper;
            order.ShipperId = shipper.Id;
            order.ShipDate = DateTime.Now.ToString();
            order.DateOrdered = orderDetail.ShipDate;        
    
            return order;


            
        }
    }
}
