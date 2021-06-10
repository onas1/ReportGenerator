using System;
using ReportModels;
using System.Collections.Generic;
using System.Text;

namespace ReportRepository.ReportInterface
{
    public interface ISupplyReport
    {
        public void InsertReport(Suppliers supplier);
        public void ReadReport(Suppliers suppliers);
        public void UpdateReport(Suppliers suppliers);
        public void DeleteReport(Suppliers suppliers);
    }
}
