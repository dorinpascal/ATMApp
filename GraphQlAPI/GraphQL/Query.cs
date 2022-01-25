using System.Linq;
using GraphQlAPI.Model;
using GraphQlAPI.Persistence;
using HotChocolate;

namespace GraphQlAPI.GraphQL
{
    public class Query
    {
        public IQueryable<Account> GetAccounts([ScopedService] ATMContext context)
        {
            return context.Accounts;
        }
    }
}