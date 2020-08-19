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
            _repository.Deposit(amount);
        }

        public void Withdraw(int amount)
        {
            _repository.Withdraw(amount);
        }

        public void PrintStatement()
        {
            statementPrinter.Print(new List<Transaction>());
        }
    }
}