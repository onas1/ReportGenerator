using System;
using ReportModels;
using System.Collections.Generic;
using System.Text;

namespace ReportRepository.ReportInterface
{
   public interface ICustomerReport
    {
        public void InsertReport(Customers customer);
        public void ReadReport(Customers customer);
        public void UpdateReport(Customers customer);
        public void DeleteReport(Customers customer);
    }
}
