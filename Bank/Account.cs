namespace Bank
{
    public class Account
    {
        private readonly IClock _clock;
        private readonly StatementPrinter statementPrinter;

        public Account(IClock clock, StatementPrinter statementPrinter)
        {
            _clock = clock;
            this.statementPrinter = statementPrinter;
        }

        public void Deposit(int amount)
        {
            throw new System.NotImplementedException();
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