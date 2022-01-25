
using System;
using System.Threading.Tasks;
using GraphQlAPI.Data;
using GraphQlAPI.GraphQL.Record;
using GraphQlAPI.Model;
using GraphQlAPI.Persistence;
using HotChocolate;

namespace GraphQlAPI.GraphQL.Mutation
{
    public class Mutation
    {
        public async Task<Transaction> AddTransaction([ScopedService] TransactionImpl context, TransactionRecord transaction)
        {
            Console.WriteLine("aleo");
            var temp = new Transaction
            {
                id = transaction.id,
                Action = transaction.Action,
                //Date = transaction.Date,
                Amount = transaction.Amount,
                Account = transaction.Account

            };
            await context.AddTransaction(temp);
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