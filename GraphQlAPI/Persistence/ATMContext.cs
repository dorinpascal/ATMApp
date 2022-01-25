using GraphQlAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace GraphQlAPI.Persistence
{
    public class ATMContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = ATM.db");
        }
    }
}