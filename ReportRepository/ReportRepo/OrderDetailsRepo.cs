using System;
using ReportData;
using ReportRepository.ReportInterface;
using System.Collections.Generic;
using System.Text;
using ReportModels;

namespace ReportRepository.ReportRepo
{
    public class OrderDetailsRepo : IOrderDetails
    {
        private DataContext dataContext = new DataContext();

        public OrderDetailsRepo(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void DeleteReport(OrderDetails orderDetails)
        {
            dataContext.Remove(orderDetails);
            dataContext.SaveChanges();
        }

        public void InsertReport(OrderDetails orderDetails)
        {
            dataContext.Add(orderDetails);
            dataContext.SaveChanges();
        }

        public void ReadReport(OrderDetails orderDetails)
        {
            throw new NotImplementedException();
        }

        public void UpdateReport(OrderDetails orderDetails)
        {
            dataContext.Update(orderDetails);
            dataContext.SaveChanges();
        }
    }
}
