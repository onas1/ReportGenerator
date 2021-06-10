using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReportData;
using ReportModels;
using ReportRepository.ReportInterface;

namespace ReportRepository.ReportRepo
{
   public class ProductRepo : IProductReport
    {
        DataContext dataContext = new DataContext();

        public ProductRepo(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void DeleteReport(Product product)
        {
            dataContext.Remove(product);
            dataContext.SaveChanges();
        }

        public void InsertReport(Product product)
        {
            dataContext.Add(product);

            //Console.Write("Enter Category ID: ");
            //int ID = int.Parse(Console.ReadLine());
            //var CatID = dataContext.Categories.Where(e => e.Id == ID).FirstOrDefault();
            //if (CatID != null)
            //    product.Category = CatID;

            //CatID.Products.Add(product);

            //Console.Write("Enter Supplier ID: ");
            //int SID = int.Parse(Console.ReadLine());
            //var supplier = dataContext.Suppliers.Where(d => d.Id == SID).FirstOrDefault();

            //if (supplier != null)
            //    supplier.products.Add(product);
           // dataContext.Update(dataContext.Categories);
           // dataContext.Update(dataContext.Suppliers);
        
                dataContext.SaveChanges();
                  
                


        }

        public void ReadReport(Product product)
        {
            throw new NotImplementedException();
        }

        public void UpdateReport(Product product)
        {
            dataContext.Update(product);
            dataContext.SaveChanges();
        }
    }
}
