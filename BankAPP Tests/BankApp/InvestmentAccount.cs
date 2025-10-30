using CustomerSystemApp.Model;
using System;
using System.Security.Principal;

namespace BankApp
{
    public class InvestmentAccount : Account
    {
        private decimal interestRate;
        private decimal withdrawalFee;

        public InvestmentAccount(decimal startBalance, decimal rate, decimal fee)
            : base(startBalance)
        {
            interestRate = rate;
            withdrawalFee = fee;
        }

        public override bool Withdraw(Customer who, decimal amount)
        {
            decimal feeToCharge = who.IsStaff ? withdrawalFee / 2 : withdrawalFee;
            decimal total = amount + feeToCharge;

            if (Balance >= total)
            {
                Balance -= total;
                LastTransactionInfo = $"Withdraw: {amount}, Fee: {feeToCharge}; New balance: {Balance}";
                return true;
            }
            else
            {
                throw new FailedWithdrawalException(
                    $"Withdrawal failed. Insufficient balance for {who.Name}. Tried to withdraw {amount + feeToCharge}, available {Balance}."
                );
            }
        }

        public override decimal AddInterest()
        {
            decimal interest = Balance * interestRate;
            Balance += interest;
            LastTransactionInfo = $"Interest added: {interest}; New balance: {Balance}";
            return interest;
        }
    }
}
