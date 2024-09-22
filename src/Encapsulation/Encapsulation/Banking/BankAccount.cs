using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Banking
{
    public class BankAccount
    {
        private string _accountNumber;
        private string _accountHolder;
        private double _balance;

        public string AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = string.IsNullOrEmpty(value) ? "Unknown" : value; }
        }

        public string AccountHolder
        {
            get { return _accountHolder; }
            set { _accountHolder = string.IsNullOrEmpty(value) ? "Unknown" : value; }
        }

        public double Balance
        {
            get { return _balance; }
            private set { _balance = value >= 0 ? value : 0; }
        }

        public BankAccount(string accountNumber, string accountHolder, double balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
                Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && (Balance - amount) >= 0)
                Balance -= amount;
        }

        public double GetBalance()
        {
            return Balance;
        }
    }

}

