using System;
using System.Security.Principal;

namespace BankApp
{
    public class EverydayAccount : Account
    {
        public EverydayAccount(decimal startBalance) : base(startBalance)
        {
        }

        public override decimal AddInterest()
        {
            LastTransactionInfo = "No interest for Everyday accounts.";
            return 0m;
        }
    }
}
