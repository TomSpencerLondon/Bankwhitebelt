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
            var transaction = new Transaction("1/1/1929", 100);
            _clockMoq.Setup(clock => clock.DateAsString()).Returns("1/1/1929");
            _account.Deposit(100);
            _repositoryMoq.Verify(repository => repository.Save(transaction));
        }

        [Test]
        public void store_a_withdrawal()
        {
            // given
            _clockMoq.Setup(clock => clock.DateAsString())
                .Returns("5/1/1929");
            // when
            var withdrawal = new Transaction("5/1/1929", -100);
            _account.Withdraw(100);

            // then
            _repositoryMoq.Verify(repository => repository.Save(withdrawal));
        }

        [Test]
        public void print_statement_with_no_transactions()
        {
            var transactions = new List<Transaction>{};

            _repositoryMoq.Setup(repository => repository.AllTransactions()).Returns(transactions);

            _account.PrintStatement();
            _statementPrinterMoq.Verify(printer => printer.Print(transactions));
        }

        [Test]
        public void print_statement_with_several_transactions()
        {
            Transaction[] input =
            {
                new Transaction("1/1/1900", 1),
                new Transaction("2/2/1929", -1)
            };
            var transactions = new List<Transaction>(input);

            _repositoryMoq.Setup(repository => repository.AllTransactions()).Returns(transactions);

            _account.PrintStatement();
            
            _statementPrinterMoq.Verify(printer => printer.Print(transactions));
        }
    }
}