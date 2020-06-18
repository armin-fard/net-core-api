using Commander.Models;
using System;
using System.Collections.Generic;  
using System.Linq;  
  
namespace Commander.DataAccess  
{  
    public class DataAccessProvider : IDataAccessProvider  
    {  
        private readonly CommanderContext _context;  
  
        public DataAccessProvider(CommanderContext context)  
        {  
            _context = context;  
        }  
  
        public void CreateInvoice(invoice invoice)  
        {  
            _context.invoice_test.Add(invoice);  
            _context.SaveChanges();  
        }  
  
        public void UpdateInvoice(invoice invoice)  
        {  
            _context.invoice_test.Update(invoice);  
            _context.SaveChanges();  
        }  
  
        public void DeleteInvoice(Guid id)  
        {  
            var entity = _context.invoice_test.FirstOrDefault(t => t.invoice_id == id);  
            _context.invoice_test.Remove(entity);  
            _context.SaveChanges();  
        }  
  
        public invoice GetSingleInvoice(Guid id)  
        {  
            return _context.invoice_test.FirstOrDefault(t => t.invoice_id == id);  
        }  
  
        public List<invoice> GetAllInvoices()  
        {  
            return _context.invoice_test.ToList();  
        }  
    }  
}  