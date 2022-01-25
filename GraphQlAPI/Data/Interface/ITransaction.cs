using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQlAPI.Model;

namespace GraphQlAPI.Data
{
    public interface ITransaction
    {
        Task<double> Deposit(double Amount);
        Task<double> Withdraw(double Amount);
        Task<IList<Transaction>> getLast5Transactions();
    }
}