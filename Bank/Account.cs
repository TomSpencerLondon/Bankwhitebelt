namespace Bank
{
    public class Account
    {
        private readonly IRepository _repository;
        private readonly IClock _clock;
        private readonly StatementPrinter statementPrinter;

        public Account(IClock clock, StatementPrinter statementPrinter)
        {
            _clock = clock;
            this.statementPrinter = statementPrinter;
        }

        public Account(IRepository repository)
        {
            _repository = repository;
        }

        public void Deposit(int amount)
        {
            _repository.DepositTransaction(amount);
        }

        public void Withdraw(int amount)
        {
            throw new System.NotImplementedException();
        }

        public void printStatement()
        {
            throw new System.NotImplementedException();
        }
    }
}