using System.Collections.Generic;

namespace Bank
{
    public class Repository : IRepository
    {
        public void Deposit(int amount)
        {
            throw new System.NotImplementedException();
        }

        public void Withdraw(int amount)
        {
            throw new System.NotImplementedException();
        }

        public List<Transaction> AllTransactions()
        {
            throw new System.NotImplementedException();
        }
    }
}