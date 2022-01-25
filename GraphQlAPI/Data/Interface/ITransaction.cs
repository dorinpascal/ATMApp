using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQlAPI.Model;

namespace GraphQlAPI.Data
{
    public interface ITransaction
    {
        Task<double> Deposit(int id, double Amount);
        Task<double> Withdraw(int id, double Amount);
        Task<IList<Transaction>> getLast5Transactions(int accountId);
    }
}