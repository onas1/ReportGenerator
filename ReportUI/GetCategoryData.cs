using System;
using System.Collections.Generic;
using System.Text;
using ReportModels;

namespace ReportUI
{
   public class GetCategoryData
    {
        public static Category GetCategoryInfo()
        {
            Category category = new Category();

            Console.WriteLine("Enter Category Name: ");
            category.CategoryName = Console.ReadLine();

            Console.WriteLine("Enter Category Description: ");
            category.Description = Console.ReadLine();

                return category;
        }

    }
}
