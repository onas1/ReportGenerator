using System;
using ReportModels;
using System.Collections.Generic;
using System.Text;

namespace ReportRepository.ReportInterface
{
   public interface ICategoryReport
    {
        public void InsertReport(Category category);
        public void ReadReport(Category category);
        public void UpdateReport(Category category);
        public void DeleteReport(Category category);

    }
}
