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
            // Given
            Repository repository = new Repository();
            
            // When
            repository.Save(new Transaction("1/1/1900", 100));
            
            // Then
            List<Transaction> transactions = repository.AllTransactions();
            Assert.That(transactions, Has.Exactly(1).True);
            Assert.That(transactions[0].Amount, Is.EqualTo(100));
            Assert.That(transactions[0].Date, Is.EqualTo("1/1/1900"));
        }
    }
}