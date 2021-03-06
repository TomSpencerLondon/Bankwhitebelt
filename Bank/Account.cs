using System.Collections.Generic;

namespace Bank
{
    public class Account
    {
        private readonly IRepository _repository;
        private readonly IClock _clock;

        private readonly IStatementPrinter statementPrinter;

        public Account(IRepository repository, IClock clock, IStatementPrinter statementPrinter)
        {
            _repository = repository;
            _clock = clock;
            this.statementPrinter = statementPrinter;
        }

        public void Deposit(int amount)
        {
            var deposit = new Transaction(_clock.DateAsString(), amount);
            
            _repository.Save(deposit);
        }

        public void Withdraw(int amount)
        {
            var withdrawal = new Transaction(_clock.DateAsString(), -amount);
            _repository.Save(withdrawal);
        }

        public void PrintStatement()
        {
            List<Transaction> transactions = _repository.AllTransactions();
            
            statementPrinter.Print(transactions);
        }
    }
}