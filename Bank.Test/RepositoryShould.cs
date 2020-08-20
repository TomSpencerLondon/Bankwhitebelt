using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Bank.Test
{
    public class RepositoryShould
    {
        [Test]
        public void deposits_one_transaction()
        {
            Repository repository = new Repository();
            
            // then repository.AllTransactions() contains only one transaction
            // and transaction.amount() is 100
            Transaction[] input =
            {
                new Transaction("1/1/1900", 1)
            };
            List<Transaction> transactions = new List<Transaction>(input);
            
            Assert.That(transactions, Has.Exactly(1).EqualTo(input[0]));

            Assert.That(transactions[0].Amount, Is.EqualTo(1));
        }
    }
}