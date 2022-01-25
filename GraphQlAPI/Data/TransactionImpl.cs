using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQlAPI.Model;
using GraphQlAPI.Persistence;

namespace GraphQlAPI.Data
{
    public class TransactionImpl : ITransaction
    {
        private readonly ATMContext context;

        
        public Task<double> Deposit(double Amount)
        {
            throw new System.NotImplementedException();
        }

        public Task<double> Withdraw(double Amount)
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<Transaction>> getLast5Transactions()
        {
            throw new System.NotImplementedException();
        }
    }
}