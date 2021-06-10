using System;
using ReportModels;
using System.Collections.Generic;
using System.Text;

namespace ReportRepository.ReportInterface
{
   public interface IOrderReport
    {
        public void InsertReport(Order order);
        public void ReadReport(Order order);
        public void UpdateReport(Order order);
        public void DeleteReport(Order order);
    }
}
