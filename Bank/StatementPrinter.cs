using System.Collections.Generic;

namespace Bank
{
    public class StatementPrinter : IStatementPrinter
    {
        private readonly Console _console;

        public StatementPrinter(Console console)
        {
            _console = console;
        }

        public void Print(List<Transaction> dateAmountBalance)
        {
            
            throw new System.NotImplementedException();
        }
    }
}