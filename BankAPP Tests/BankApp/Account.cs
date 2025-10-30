using CustomerSystemApp.Model;
using System;

namespace BankApp
{
    // base class
    public class Account
    {
        public int Id { get; set; }
        public decimal Balance { get; protected set; }
        public string LastTransactionInfo { get; protected set; }

        public Account(decimal startBalance)
        {
            Balance = startBalance;
            LastTransactionInfo = "Account created. Balance: " + Balance;
        }

        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
            LastTransactionInfo = "Deposit: " + amount + "; New balance: " + Balance;
        }

        public virtual bool Withdraw(Customer who, decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                LastTransactionInfo = "Withdraw: " + amount + "; New balance: " + Balance;
                return true;
            }
            else
            {
                LastTransactionInfo = "Failed withdraw: not enough balance";
                return false;
            }
        }

        public virtual decimal AddInterest()
        {
            LastTransactionInfo = "Interest not available for this account";
            return 0m;
        }

        public virtual string Info()
        {
            return "Account Id: " + Id + "; Balance: " + Balance;
        }
    }
}
