using System.Collections.Generic;

namespace Bank
{
    public interface IRepository
    {
        void Save(Transaction transaction);
        void Withdraw(int amount);
        List<Transaction> AllTransactions();
    }
}