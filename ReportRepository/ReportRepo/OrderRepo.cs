using System;
using ReportRepository.ReportInterface;
using System.Collections.Generic;
using System.Text;
using ReportModels;
using ReportData;

namespace ReportRepository.ReportRepo
{
   public class OrderRepo : IOrderReport
    {
        private DataContext dataContext = new DataContext();

        public OrderRepo(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void DeleteReport(Order order)
        {
            dataContext.Remove(order);
            dataContext.SaveChanges();
        }

        public void InsertReport(Order order)
        {
            dataContext.Add(order);
            dataContext.SaveChanges();
        }

        public void ReadReport(Order order)
        {
            throw new NotImplementedException();
        }

        public void UpdateReport(Order order)
        {
            dataContext.Update(order);
            dataContext.SaveChanges();
        }
    }
}
