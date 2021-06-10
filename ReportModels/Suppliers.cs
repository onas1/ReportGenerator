using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ReportModels
{
    public  class Suppliers
    {
       
        public int Id { get; set; }
       
        public string SupplierCompanyName { get; set; }
     
        public string Email { get; set; }
      
        public string PhoneNumber { get; set; }
      
        public Address Address { get; set; }
     
        public virtual ICollection<Product> products { get; set; }


    }
}
