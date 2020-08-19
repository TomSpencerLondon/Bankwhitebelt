namespace Bank
{
    public interface IRepository
    {
        void Deposit(int amount);
        void Withdraw(int amount);
    }
}