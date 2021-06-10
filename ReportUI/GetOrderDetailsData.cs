using System;
using ReportData;
using ReportModels;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ReportUI
{
   public class GetOrderDetailsData
    {

        public static OrderDetails GetOrderDetailsInfo()
        {
            DataContext dataContext = new DataContext();
            OrderDetails orderDetail = new OrderDetails();

            

            Order neworder = dataContext.Orders.Find();

            Console.Write("Enter Product ID to Order: ");
            int PId = int.Parse(Console.ReadLine());

            Product prodID = dataContext.products.Find(PId);





            // Product newproduct     = dataContext.products.Find(PId);
            

            orderDetail.Product = prodID; 
            Console.WriteLine($"Enter Quantity of {prodID.ProductName} ");
            int Qty = int.Parse(Console.ReadLine());
            orderDetail.Quantity = Qty;
            orderDetail.UnitPrice = prodID.UnitPrice;
            orderDetail.ProductId = prodID.Id;
            //orderDetail.OrderId = neworder.Id;
           orderDetail.ShipDate = DateTime.Now;

            

            return orderDetail;

            

        }
    }
}
