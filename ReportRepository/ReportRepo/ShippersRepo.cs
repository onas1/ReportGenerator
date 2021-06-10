using System;
using ReportData;
using ReportRepository.ReportInterface;
using System.Collections.Generic;
using System.Text;
using ReportModels;

namespace ReportRepository.ReportRepo
{
    public class ShippersRepo : IShipperReport
    {
        private DataContext dataContext = new DataContext();

        public ShippersRepo(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void DeleteReport(Shippers shippers)
        {
            dataContext.Remove(shippers);
            dataContext.SaveChanges();
        }

        public void InsertReport(Shippers shippers)
        {
            dataContext.Add(shippers);
            dataContext.SaveChanges();
        }

        public void ReadReport(Shippers shippers)
        {
            throw new NotImplementedException();
        }

        public void UpdateReport(Shippers shippers)
        {
            dataContext.Update(shippers);
            dataContext.SaveChanges();
        }
    }
}
