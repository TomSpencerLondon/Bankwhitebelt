using System.Collections.Generic;

namespace Bank
{
    public class Repository : IRepository
    {
        public void Save(Transaction transaction)
        {
            throw new System.NotImplementedException();
        }

        public void Withdraw(Transaction transaction)
        {
            throw new System.NotImplementedException();
        }
        
        public List<Transaction> AllTransactions()
        {
            throw new System.NotImplementedException();
        }
    }
}