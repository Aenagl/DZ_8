using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using LABS;
using System.IO;

namespace LABS
{
    internal class BankAccount: IDisposable
    {
        #region Feild
        /// <summary>
        /// Номер счёта
        /// </summary>
        private readonly int number;
        private static int numberCounter = 0;
        /// <summary>
        /// Тип счёта
        /// </summary>
        private Types type;
        /// <summary>
        /// Баланс счёта
        /// </summary>
        private decimal balance;
        private Queue<BankTransaction> _transaction;
        #endregion

        #region Constructors
        public BankAccount(Types type, decimal balance)
        {
            number = CustomNumber();
            this.type = type;
            this.balance = balance;
        }
        public BankAccount()
        {
            number = CustomNumber();
        }
        public BankAccount(decimal balance)
        {
            this.balance = balance;
            this.number = CustomNumber();
        }
        public BankAccount(Types type)
        {
            this.type = type;
            this.number = CustomNumber();
        }
        #endregion

        #region Method
        public void ConsoleAccountInfo()
        {
            Console.WriteLine($"Номер счёта: {number}");
            Console.WriteLine($"Баланс: {balance}");
            Console.WriteLine($"Тип счёта: {type}");
        }
        private static int CustomNumber()
        {
            return ++numberCounter;
        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                BankTransaction transaction = new BankTransaction(amount);
                _transaction.Enqueue(transaction); //добавляем транзакцию в очередь
            }
        }

        public void WithDraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                BankTransaction transaction = new BankTransaction(amount);
                _transaction.Enqueue(transaction);
            }
        }
        public void Dispose()
        {
            using (StreamWriter writer = new StreamWriter("transactions.txt")) //объект StreamWriter для записи в файл transactions.txt
            {
                while (_transaction.Count > 0)
                {
                    BankTransaction transaction = _transaction.Dequeue(); //Извлекает и удаляет объект BankTransaction из очереди
                    writer.WriteLine($"{transaction.TransactionDate}: {transaction.Amount}");
                }
            }
            GC.SuppressFinalize(this); 
        }
        #endregion
    }
}
