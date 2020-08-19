using System.Collections.Generic;
using Moq;
using NUnit.Framework;

namespace Bank.Test
{
    public class AccountShould
    {
        private Mock<IRepository> _repositoryMoq;
        private Account _account;
        private Mock<IStatementPrinter> _statementPrinterMoq;
        private Mock<IClock> _clockMoq;

        [SetUp()]
        public void Initialize()
        {
            _clockMoq = new Mock<IClock>();
            _statementPrinterMoq = new Mock<IStatementPrinter>();
            _repositoryMoq = new Mock<IRepository>();
            _account = new Account(_repositoryMoq.Object, _clockMoq.Object, _statementPrinterMoq.Object);
        }

        [Test]
        public void store_a_deposit()
        {
            int amount = 100;
            _account.Deposit(amount);
            _repositoryMoq.Verify(repository => repository.Deposit(amount));
        }

        [Test]
        public void store_a_withdrawal()
        {
            int amount = 100;
            _account.Withdraw(amount);
            _repositoryMoq.Verify(repository => repository.Withdraw(amount));
        }

        [Test]
        public void print_statement_with_no_transactions()
        {
            _account.PrintStatement();
            _statementPrinterMoq.Verify(printer => printer.Print(new List<Transaction>{}));
        }
    }
}