using Commander.Models;
using System;
using System.Collections.Generic;  
  
namespace Commander.DataAccess  
{  
    public interface IDataAccessProvider  
    {  
        void CreateInvoice(invoice invoice);  
        void UpdateInvoice(invoice invoice);  
        void DeleteInvoice(Guid id);  
        invoice GetSingleInvoice(Guid id);  
        List<invoice> GetAllInvoices();  
    }  
}  