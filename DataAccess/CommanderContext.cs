using Microsoft.EntityFrameworkCore;  
using Commander.Models;  
  
namespace Commander.DataAccess  
{  
    public class CommanderContext: DbContext  
    {  
        public CommanderContext(DbContextOptions<CommanderContext> options) : base(options)  
        {  
        }  
  
        public DbSet<invoice> invoice_test { get; set; }  
  
        protected override void OnModelCreating(ModelBuilder builder)  
        {  
            base.OnModelCreating(builder);  
        }  
  
        public override int SaveChanges()  
        {  
            ChangeTracker.DetectChanges();  
            return base.SaveChanges();  
        }  
    }  
}  