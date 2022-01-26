using System.Threading.Tasks;
using GraphQlAPI.Model;

namespace GraphQlAPI.Data.Interface
{
    public interface IAccount
    {
        public Task<Account> ValidateAccount(string AccountNumber);
    }
}