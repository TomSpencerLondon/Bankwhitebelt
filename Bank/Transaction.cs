namespace Bank
{
    public class Transaction : ITransaction
    {
        private readonly string _date;
        private readonly int _amount;

        public Transaction(string date, int amount)
        {
            _date = date;
            _amount = amount;
        }

        public string Date => _date;

        public int Amount => _amount;
    }
}