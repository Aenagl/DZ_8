using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABS
{
    internal class BankTransaction
    {
        #region Fields
        public readonly DateTime TransactionDate;
        public readonly decimal Amount;
        #endregion

        public BankTransaction(decimal amount)
        {
            TransactionDate = DateTime.Now;
            Amount = amount;
        }
    }
}