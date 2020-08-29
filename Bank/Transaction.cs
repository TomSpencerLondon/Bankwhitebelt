using System;

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


        public override bool Equals(Object obj)
        {
            Transaction t = obj as Transaction;

            if (t == null) return false;

            return _amount == t._amount
                   && _date == t.Date;
        }

        protected bool Equals(Transaction other)
        {
            return _date == other._date && _amount == other._amount;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((_date != null ? _date.GetHashCode() : 0) * 397) ^ _amount;
            }
        }
    }
}