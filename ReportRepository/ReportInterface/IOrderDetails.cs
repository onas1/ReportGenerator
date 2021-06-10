using System;
using ReportModels;
using ReportRepository.ReportRepo;
using System.Collections.Generic;
using System.Text;

namespace ReportRepository.ReportInterface
{
    public interface IOrderDetails
    {
        public void InsertReport(OrderDetails orderDetails);
        public void ReadReport(OrderDetails orderDetails);
        public void UpdateReport(OrderDetails orderDetails);
        public void DeleteReport(OrderDetails orderDetails);
    }
}
