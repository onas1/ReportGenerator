using System;
using ReportRepository.ReportInterface;
using ReportModels;
using ReportData;
using System.Linq;

namespace ReportRepository.ReportRepo
{
    public class CustomersRepo : ICustomerReport
    {
        
        private DataContext dataContext;
        public CustomersRepo(DataContext dataContext1)
        {
            this.dataContext = dataContext1;
        }

        public void DeleteReport(Customers customer) 
        {
            dataContext.Remove(customer);
            dataContext.SaveChanges();
        }


        public void InsertReport(Customers customer)
        {
            dataContext.Add(customer);
            dataContext.SaveChanges();

        }

        public void ReadReport(Customers customer)
        {
            var Customer = dataContext.customers.ToList();
            foreach (var User in Customer)
            {
                Console.WriteLine($"{User.Id}" +
                    $" {User.FirstName} " +
                    $"{User.LastName} " +
                    $"{User.Address.StreetAddress} " +
                    $"{User.Address.City} " +
                    $"{User.Address.State} " +
                    $"{User.Address.Country}" +
                    $" {User.Email} " +
                    $"{User.Number}"
                   );
            }
        }

        public void UpdateReport(Customers customer)
        {
            dataContext.Update(customer);
            dataContext.SaveChanges();
        }

        
        
    }
}
