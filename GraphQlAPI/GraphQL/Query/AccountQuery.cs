using System;
using System.Linq;
using GraphQlAPI.Model;
using GraphQlAPI.Persistence;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;

namespace GraphQlAPI.GraphQL.Query
{
    [ExtendObjectType(Name = "Query")]
    public class AccountQuery
    { 
        
        [UseDbContext(typeof(ATMContext))]
        [GraphQLDescription("Get an account")]
        public IQueryable<Account> GetAccount([ScopedService] ATMContext context)
        {
            try
            {
                return context.Accounts;
            }
            catch (Exception e)
            {
                Console.WriteLine("aleo");
                throw;
            }
           
        }
    }
}