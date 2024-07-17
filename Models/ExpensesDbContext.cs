using Microsoft.EntityFrameworkCore;

namespace aspdotnet_ef_example.Models
{
    public class ExpensesDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        public ExpensesDbContext(DbContextOptions<ExpensesDbContext> options)
            : base(options) 
        {
            
        }
    }
}
