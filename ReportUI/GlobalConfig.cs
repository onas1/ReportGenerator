using System;
using ReportRepository.ReportInterface;
using ReportRepository.ReportRepo;
using System.Collections.Generic;
using System.Text;
using ReportData;

namespace ReportUI
{
   public class GlobalConfig
    {
        public ICustomerReport customer;
        public ICategoryReport category; 
        public IOrderReport order;
        public IOrderDetails orderDetails;
        public IProductReport productReport;
        public  IShipperReport shipperReport;
        public ISupplyReport supplyReport;
        private DataContext dataContext;
        
        public void AddInstance()
        {
            dataContext = new DataContext();
            customer = new CustomersRepo(dataContext);
            category = new CategoryRepo(dataContext );
            order = new OrderRepo(dataContext);
            orderDetails = new OrderDetailsRepo(dataContext);
            productReport = new ProductRepo(dataContext);
            shipperReport = new ShippersRepo(dataContext);
            supplyReport = new SupplierRepo(dataContext);
        }

    }
   
}
