using Moq;
using NUnit.Framework;

namespace Bank.Test
{
    public class AccountShould
    {
        private Mock<IRepository> _repositoryMoq;
        private Account _account;

        [SetUp()]
        public void initialize()
        {
            _repositoryMoq = new Mock<IRepository>();
            _account = new Account(_repositoryMoq.Object);
        }
        
        [Test]
        public void store_a_deposit()
        {

            int amount = 100;
            _account.Deposit(amount);
            
            _repositoryMoq.Verify(repository => repository.DepositTransaction(amount));
        }
    }
}