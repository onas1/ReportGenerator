using System;
using ReportModels;
using System.Collections.Generic;
using System.Text;

namespace ReportRepository.ReportInterface
{
   public interface IProductReport
    {
        public void InsertReport(Product product);
        public void ReadReport(Product product);
        public void UpdateReport(Product product);
        public void DeleteReport(Product product);
    }
}
