using System;
using System.Collections.Generic;
using System.Text;
using ReportRepository.ReportInterface;
using ReportModels;
using ReportData; 


namespace ReportRepository.ReportRepo
{
    public class CategoryRepo : ICategoryReport
    {
        DataContext dataContext;

        public CategoryRepo(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void DeleteReport(Category category)
        {
            dataContext.Remove(category);
            dataContext.SaveChanges();
        }

        public void InsertReport(Category category)
        {
            dataContext.Add(category);
            dataContext.SaveChanges();
        }

        public void ReadReport(Category category)
        {
            throw new NotImplementedException();
        }

        public void UpdateReport(Category category)
        {
            dataContext.Update(category);
            dataContext.SaveChanges();
        }
    }
}
