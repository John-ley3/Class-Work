using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise.Classes
{
    public class CheckingAccount : BankAccount
    {

        public CheckingAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance)
        {

        }

        public CheckingAccount(string accountHolderName, string accountNumber) : base(accountHolderName, accountNumber)
        {

        }

        public override decimal Withdraw(decimal amountToWithdraw)
        {
            decimal balance = 0M;

            if((Balance - amountToWithdraw) < -100)
            {
                return Balance;
            }
            else if((Balance - amountToWithdraw) < 0)
            {
                base.Withdraw(amountToWithdraw);
                balance = base.Withdraw(10M);
                return balance;
            }
            else
            {
                balance = base.Withdraw(amountToWithdraw);
                return balance;
            }

        }
    }
}
