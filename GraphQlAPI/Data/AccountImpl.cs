using System.Linq;
using System.Threading.Tasks;
using GraphQlAPI.Model;
using GraphQlAPI.Persistence;
using Microsoft.EntityFrameworkCore;

namespace GraphQlAPI.Data
{
    public class AccountImpl : IAccount
    {
        private readonly ATMContext context;

        public AccountImpl(ATMContext context)
        {
            this.context = context;
            context.Database.EnsureCreated();
        }

        public async Task<Account> ValidateAccount(string AccountNumber, string Password)
        {
            return await context.Accounts.Where(a =>
                (
                    a.AccountNumber == AccountNumber
                ) &&
                (
                    a.Password == Password
                )).FirstOrDefaultAsync();
        }
    }
}