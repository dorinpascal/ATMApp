using System.Threading.Tasks;
using GraphQlAPI.Model;

namespace GraphQlAPI.Data
{
    public interface IAccount
    {
        public Task<Account> ValidateAccount(string AccountNumber, string Password);
    }
}