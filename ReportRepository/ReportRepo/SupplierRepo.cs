using System;
using ReportRepository.ReportInterface;
using System.Collections.Generic;
using System.Text;
using ReportModels;
using ReportData;

namespace ReportRepository.ReportRepo
{
    public class SupplierRepo : ISupplyReport
    {
       private DataContext dataContext = new DataContext();

        public SupplierRepo(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void DeleteReport(Suppliers suppliers)
        {
            dataContext.Remove(suppliers);
            dataContext.SaveChanges();
        }

        public void InsertReport(Suppliers supplier)
        {
            dataContext.Add(supplier) ;
            dataContext.SaveChanges();
        }

        public void ReadReport(Suppliers suppliers)
        {
            throw new NotImplementedException();
        }

        public void UpdateReport(Suppliers suppliers)
        {
            dataContext.Update(suppliers);
            dataContext.SaveChanges();
        }
    }
}
