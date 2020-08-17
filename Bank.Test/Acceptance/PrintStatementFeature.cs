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
            var consoleMoq = new Mock<Console>();
            var clockMoq = new Mock<Clock>();

            clockMoq.SetupSequence(clock => clock.DateAsString())
                .Returns("10/04/2014")
                .Returns("02/04/2014")
                .Returns("01/04/2014");
            
            var account = new Account(clockMoq.Object, consoleMoq.Object);

        }
    }
}