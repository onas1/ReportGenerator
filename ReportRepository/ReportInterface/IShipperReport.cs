using System;
using ReportModels;
using ReportRepository.ReportRepo;
using System.Collections.Generic;
using System.Text;

namespace ReportRepository.ReportInterface
{
   public interface IShipperReport
    {
        public void InsertReport(Shippers shippers);
        public void ReadReport(Shippers shippers);
        public void UpdateReport( Shippers shippers);
        public void DeleteReport(Shippers shippers);
    }
}
