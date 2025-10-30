using System;
using System.Security.Principal;

namespace BankApp
{
    public class OmniAccount : Account
    {
        private decimal interestRate;

        public OmniAccount(decimal startBalance, decimal rate) : base(startBalance)
        {
            interestRate = rate;
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
