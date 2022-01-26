using System.Linq;
using System.Threading.Tasks;
using GraphQlAPI.Data.Interface;
using GraphQlAPI.Model;
using GraphQlAPI.Persistence;
using Microsoft.EntityFrameworkCore;

namespace GraphQlAPI.Data
{
    /*public class AccountImpl : IAccount
    {
        private readonly ATMContext context;

        public AccountImpl(ATMContext context)
        {
            this.context = context;
            context.Database.EnsureCreated();
        }

        public async Task<Account> ValidateAccount(string AccountNumber)
        {
            return await context.Accounts.Where(a =>
                
                    a.AccountNumber == AccountNumber
                ).FirstOrDefaultAsync();
        }
    }*/
}