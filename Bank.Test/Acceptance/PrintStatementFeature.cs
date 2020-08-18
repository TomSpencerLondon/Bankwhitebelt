using System.Linq.Expressions;
using NUnit.Framework;
using Moq;
namespace Bank.Test.Acceptance
{
    public class PrintStatementFeature
    {
        
        [Test]
        public void should_print_statement_containing_all_transactions()
        {
            // Given
            var consoleMoq = new Mock<Console>();
            var clockMoq = new Mock<IClock>();

            clockMoq.SetupSequence(clock => clock.DateAsString())
                .Returns("01/04/2014")
                .Returns("02/04/2014")
                .Returns("10/04/2014");


            var statementPrinter = new StatementPrinter(consoleMoq.Object);
            var account = new Account(clockMoq.Object, statementPrinter);
            
            // When
            account.Deposit(1000);

            account.Withdraw(100);

            account.Deposit(500);

            account.printStatement();
            
            consoleMoq.Verify(console => console.printLine("DATE | AMOUNT | BALANCE"));
            consoleMoq.Verify(console => console.printLine("10/04/2014 | 500.00 | 1400.00"));
            consoleMoq.Verify(console => console.printLine("02/04/2014 | -100.00 | 900.00"));
            consoleMoq.Verify(console => console.printLine("01/04/2014 | 1000.00 | 1000.00"));
        }
    }
}