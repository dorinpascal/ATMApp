
using System;
using System.Threading.Tasks;
using GraphQlAPI.Data;
using GraphQlAPI.Data.Interface;
using GraphQlAPI.GraphQL.Record;
using GraphQlAPI.Model;
using GraphQlAPI.Persistence;
using HotChocolate;
using HotChocolate.Data;

namespace GraphQlAPI.GraphQL.Mutation
{
    public class Mutation
    {
        [UseDbContext(typeof(ATMContext))]
        [GraphQLDescription("Adds a transaction.")]
        public async Task<Transaction> AddTransaction([ScopedService] ATMContext context, Transaction transaction)
        {
            Console.WriteLine("aleo");
            Console.WriteLine(transaction.Action+ "lalala");
            Console.WriteLine("aleo");
            Transaction temp = new Transaction
            {
                id = transaction.id,
                Action = transaction.Action,
                //Date = transaction.Date,
                Amount = transaction.Amount,
                AccountId = transaction.AccountId

            };
            Console.WriteLine("aleox2");
            await context.Transactions.AddAsync(transaction);
            await context.SaveChangesAsync();
            Console.WriteLine("aleox3");
            return temp;
        }

        /*public async Task<Account> UpdateAccount([Service] AccountImpl context, AccountRecord accountRecord)
        {
            var temp=new Account
            {
                id = accountRecord.Id,
                AccountNumber = accountRecord.AccountNumber,
            }
        }
        public async Task<Transaction> Withdraw([Service] TransactionImpl context, Transaction transaction)
        {
            var temp = new Transaction
            {
                id = transaction.id,
                Action = transaction.Action,
                Date = transaction.Date,
                Amount = transaction.Amount,
                Account = transaction.Account

            };
        }*/
        
    }
}