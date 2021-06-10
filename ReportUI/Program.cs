using System;
using ReportData;
using System.Linq;
using ReportRepository.ReportInterface;
using ReportRepository;

namespace ReportUI
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext dataContext = new DataContext();

            GlobalConfig globalConfig = new GlobalConfig();
            globalConfig.AddInstance();
            ICustomerReport customer = globalConfig.customer;
            ICategoryReport categoryReport = globalConfig.category;
            IOrderReport orderReport = globalConfig.order;
            IOrderDetails orderDetails = globalConfig.orderDetails;
            IShipperReport shipperReport = globalConfig.shipperReport;
            ISupplyReport supplyReport = globalConfig.supplyReport;
            IProductReport productReport = globalConfig.productReport;



            //orderReport.InsertReport(GetOrderData.GetOrderInfo());

            //var User = GetCustomerData.GetCustomersInfo();
            //customer.InsertReport(User);


            //var cat = GetCategoryData.GetCategoryInfo();
            //categoryReport.InsertReport(cat);

            //GetProductData.GeProductInfo();
            //productReport.InsertReport(product);
            //var supp = GetSupplierData.GetSuppliersInfo();
            //supplyReport.InsertReport(supp);


            //var ord = GetOrderDetailsData.GetOrderDetailsInfo();
            //orderDetails.InsertReport(ord);

            Query query = new Query();
            query.GetTopDeal();

            Console.WriteLine();
            Console.WriteLine();
            query.GetSalesReport();


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Get Customer By City:***********");
            query.GetCustomerByCity();
            Console.WriteLine();
            Console.WriteLine();
            query.GetCustomerAbove50k();



        }
    }
}
