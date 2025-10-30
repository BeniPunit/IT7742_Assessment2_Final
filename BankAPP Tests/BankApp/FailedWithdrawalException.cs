using System;

namespace BankApp
{
    // Custom exception for failed withdrawals
    public class FailedWithdrawalException : Exception
    {
        public FailedWithdrawalException(string message) : base(message)
        {
        }
    }
}
