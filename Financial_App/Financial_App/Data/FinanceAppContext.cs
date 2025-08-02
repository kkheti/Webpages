using Financial_App.Models;
using Microsoft.EntityFrameworkCore;

namespace Financial_App.Data
{
// Bridge between the database and Model 
    public class FinanceAppContext: DbContext
    {
        public FinanceAppContext(DbContextOptions<FinanceAppContext>options):base(options) { }

       public DbSet<Expense> Expenses {  get; set; }
    }
}
