using System;
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
        public TransactionImpl(ATMContext context)
        {
            this.context = context;
        }
        public async Task AddTransaction(Transaction transaction)
        {
            await context.Transactions.AddAsync(transaction);
            await context.SaveChangesAsync();
        }

        public async Task<Transaction> GetTransaction(int id)
        {
            return await context.Transactions.Where(t => t.id == id).FirstAsync();
        }
        
        public async Task<List<Transaction>> GetAllTransaction()
        {
            return await context.Transactions.ToListAsync();
        }

        public async Task<IList<Transaction>> GetLast5Transactions(int accountId)
        {
            IList<Transaction> temp = new List<Transaction>();
            IList<Transaction> transactions = await context.Transactions.Where(t => t.Account.id == accountId).ToListAsync();
            for (int i = transactions.Count; i > transactions.Count-5; i--)
            {
                temp.Add(transactions[i]);
            }

            return temp;
        }
    }
}