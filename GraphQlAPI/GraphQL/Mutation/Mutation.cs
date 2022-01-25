
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
        public async Task<Transaction> AddTransaction([Service] TransactionImpl context, TransactionRecord transaction)
        {
            var temp = new Transaction
            {
                id = transaction.id,
                Action = transaction.Action,
                Date = transaction.Date,
                Amount = transaction.Amount,
                Account = transaction.Account

            };
            return null;
        }
    }
}