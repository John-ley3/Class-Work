using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountHolderName, string accountNumber, decimal balance) : base(accountHolderName, accountNumber, balance)
        {

        }

        public SavingsAccount(string accountHolderName, string accountNumber) : base(accountHolderName, accountNumber)
        {

        }

        public override decimal Withdraw(decimal amountToWithdraw)
        {
            decimal withdrawDifference = Balance - amountToWithdraw;

            if(withdrawDifference > 150)
            {
                base.Withdraw(amountToWithdraw);
                return Balance;
            }
            else if(withdrawDifference < 150 && (withdrawDifference - 2) >= 0)
            {
                base.Withdraw(amountToWithdraw);
                base.Withdraw(2M);

                return Balance;
            }
            else if(withdrawDifference < 0)
            {
                return Balance;
            }
            else
            {
                return Balance;
            }
        }
    }
}
