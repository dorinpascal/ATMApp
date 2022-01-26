using GraphQlAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace GraphQlAPI.Persistence
{
    public class ATMContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; } = default;
        public DbSet<Transaction> Transactions { get; set; } = default;

        public ATMContext(DbContextOptions<ATMContext> options) : base(options)
        {
            
        }
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = ATM.db");
        }*/

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().HasIndex(a => a.id).IsUnique();
            modelBuilder.Entity<Transaction>().HasIndex(a => a.id).IsUnique();
        }*/
    }
}