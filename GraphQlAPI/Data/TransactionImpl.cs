using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQlAPI.Model;
using GraphQlAPI.Persistence;
using Microsoft.EntityFrameworkCore;

namespace GraphQlAPI.Data
{
    public class TransactionImpl : ITransaction
    {
        private readonly ATMContext context;
        // private Transaction transaction;
        
        public async Task<double> Deposit(int id, double Amount)
        {
            var ruble = await context.Transactions.Where(t
                => t.id == id).FirstOrDefaultAsync();
            ruble.Amount == Amount;
            
            await context.SaveChangesAsync();
            return 0;
        }

        public async Task<double> Withdraw(int id, double Amount)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IList<Transaction>> getLast5Transactions(int accountId)
        {
            var acc = await context.Accounts.Where(a
                => a.id == accountId).FirstOrDefaultAsync();

            context.Transactions.AddAsync(acc);

            // throw new System.NotImplementedException();
        }
    }
}