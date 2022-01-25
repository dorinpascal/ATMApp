using System;
using System.Linq;
using GraphQlAPI.Model;
using GraphQlAPI.Persistence;
using HotChocolate;

namespace GraphQlAPI.GraphQL.Query
{
    public class Query
    {
        public IQueryable<Account> GetAccounts([ScopedService] ATMContext context)
        {
            Console.WriteLine("aleo");
            return context.Accounts;
        }
    }
}