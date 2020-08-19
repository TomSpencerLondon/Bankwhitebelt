using System.Collections.Generic;

namespace Bank
{
    public interface IStatementPrinter
    {
        void Print(List<Transaction> dateAmountBalance);
    }
}