using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankApp; // Testing only the BankApp
using System;

namespace BankAppTests
{
    [TestClass]
    public class AccountTests_New
    {
        [TestMethod]
        public void Deposit_IncreasesBalance()
        {
            var acc = new Account(100);
            acc.Deposit(75);
            Assert.AreEqual(175, acc.Balance, "Deposit did not increase balance correctly.");
        }

        [TestMethod]
        public void Withdraw_WithSufficientFunds_Succeeds()
        {
            var acc = new Account(200);
            var cust = new BankApp.Customer(1, "Neha", false);

            bool result = acc.Withdraw(cust, 100);
            Assert.IsTrue(result, "Withdrawal should have succeeded.");
            Assert.AreEqual(100, acc.Balance);
        }

        [TestMethod]
        public void Withdraw_WithInsufficientFunds_Fails()
        {
            var acc = new Account(50);
            var cust = new BankApp.Customer(2, "Ravi", false);

            bool result = acc.Withdraw(cust, 100);
            Assert.IsFalse(result, "Withdrawal should fail when balance is low.");
            Assert.AreEqual(50, acc.Balance);
        }

        [TestMethod]
        public void OmniAccount_AddsInterestCorrectly()
        {
            var acc = new OmniAccount(500, 0.10m); // 10% interest
            decimal added = acc.AddInterest();

            Assert.AreEqual(50, added, "Interest calculation incorrect.");
            Assert.AreEqual(550, acc.Balance);
        }

        [TestMethod]
        public void InvestmentAccount_Withdraw_ChargesFeeProperly()
        {
            var acc = new InvestmentAccount(300, 0.05m, 10);
            var cust = new BankApp.Customer(3, "Karan", false);

            bool result = acc.Withdraw(cust, 100);
            Assert.IsTrue(result);
            Assert.AreEqual(190, acc.Balance); // 300 - (100 + 10)
        }

        [TestMethod]
        [ExpectedException(typeof(FailedWithdrawalException))]
        public void InvestmentAccount_ThrowsException_WhenLowBalance()
        {
            var acc = new InvestmentAccount(50, 0.05m, 10);
            var cust = new BankApp.Customer(4, "Meera", false);

            acc.Withdraw(cust, 100); // Should trigger exception
        }

        [TestMethod]
        public void EverydayAccount_HasNoInterest()
        {
            var acc = new EverydayAccount(400);
            decimal added = acc.AddInterest();

            Assert.AreEqual(0, added);
            Assert.AreEqual(400, acc.Balance);
        }

        [TestMethod]
        public void InvestmentAccount_AddInterest_IncreasesBalance()
        {
            var acc = new InvestmentAccount(1000, 0.05m, 10);
            decimal added = acc.AddInterest();

            Assert.AreEqual(50, added);
            Assert.AreEqual(1050, acc.Balance);
        }
    }
}
